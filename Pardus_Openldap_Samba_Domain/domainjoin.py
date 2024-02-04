#!/usr/bin/python
# -*- coding: utf-8 -*-

# Gerekli, moduller
#   getpass: kullanicidan parola alirken parolanin gozukmemesini saglar
#   subprocess: process ile linux komutlarini cagirip ciktilarini almaya yarar
#   re: metin iceirsinde belirli sablonlara gore araya yapmaya yarar. Config dosyalarini degistirirken icin kullanilir.
import getpass, subprocess, re, os

# Domaine almak icin kullanilan configuration dosyalari
f_dns = "/etc/resolv.conf"
f_hosts = "/etc/hosts"
f_samba = "/etc/samba/smb.conf"
f_realm = "/etc/realmd.conf"
f_kerberos = "/etc/krb5.conf"
f_ligtdm = "/etc/lightdm/lightdm.conf"
f_sudoers = "/etc/sudoers.d/domainadmins"
f_sssd = "/etc/sssd/sssd.conf"
PATH_IFUP = "/etc/network/if-up.d/dns-update"

# Samba client-server mantigiyla calisir. Makineyis istemci olarak ayarlayabilmek icin gerekir.
def addSAMBA(workgroup,realm):
    with open(f_samba, "w") as sambafile:
        sambafile.write("""
[global]
unix charset=UTF-8
workgroup = """ + workgroup + """
client signing = yes
client use spnego = yes
dedicated keytab file = /etc/krb5.keytab
kerberos method = secrets and keytab
realm = """ + realm + """
dns proxy = no
map to guest = Bad User
log file = /var/log/samba/log.%m
max log size = 1000
syslog = 0
panic action = /usr/share/samba/panic-action %d """)

# realmd servisi SSSD'yi otomatik bir sekilde yapilandirir. Boylece kullanici girisleri icin mapping yapilir
def addREALM(realm):
	proc = subprocess.Popen("lsb_release -r | cut -d':' -f2 | xargs", stdout=subprocess.PIPE, shell=True)
	(version, err) = proc.communicate()
	proc = subprocess.Popen("lsb_release -i | cut -d':' -f2 | xargs", stdout=subprocess.PIPE, shell=True)
	(distname, err) = proc.communicate()
	if (distname=="Pardus" and "17" in version):
		with open(f_samba, "a") as sambafile:
			sambafile.write("""client min protocol = SMB2
client max protocol = SMB3""")
	with open(f_realm, "w") as realmfile:
		realmfile.write("""[users]
default-home = /home/%D/%U
default-shell = /bin/bash
[active-directory]
default-client = sssd
os-name = """ + distname + """
os-version = """ + version + """
[service]
automatic-install = no
[""" + realm + """]
fully-qualified-names = no
automatic-id-mapping = yes
user-principal = yes
manage-system = no""")

# Samba/AD sunucusu ile istemcimizin zamanini esitler. Donanim saatini gunceller.
def setTime(ntpserver):
    cmd=subprocess.Popen("ntpdate "+ntpserver, stdout=subprocess.PIPE, shell=True)
    cmd.communicate()
    cmd=subprocess.Popen("hwclock --systohc", stdout=subprocess.PIPE, shell=True)
    cmd.communicate()

# Domaine alabilmek icin gerekli olan paketleri ve kutuphaneleri yukler
def installDependences():
    try:
        cmd = subprocess.Popen("DEBIAN_FRONTEND=noninteractive apt-get update",shell=True)
        cmd.communicate()

        cmd = subprocess.Popen("DEBIAN_FRONTEND=noninteractive apt-get install krb5-user samba sssd libsss-sudo ntpdate realmd packagekit adcli sssd-tools cifs-utils smbclient -y", shell=True)
        cmd.communicate()
        print("Gereksinimler yuklendi")
    except Exception as error:
        print("Hata:",error)

# DNS olarak AD/Samba sunucusunun IP adresi ayarlanmalidir. 
def editDNS(domain_ip,domain):
     # DNS ayarlarini duzenle
    try:
        # resolv.conf dosyasinin kilidini kaldirir
        cmd = subprocess.Popen("chattr -i " + f_dns,shell=True)
        cmd.communicate()
        # resolv.conf dns olarak domain sunucsunu verir
        f = open(f_dns, "w")
        text = """nameserver %s
search %s
domain %s
""" % (domain_ip, domain, domain)
        f.write(text)
        f.close()
        # resolv.conf dosyasini kilitler
        cmd = subprocess.Popen("chattr +i " + f_dns,shell=True)
        cmd.communicate()
        print("DNS basariyla guncellendi")
    except Exception as error:
        print("Hata, DNS ayarlanamadi:",error)

# Domaindeki DNS'e kendisini kaydettirebilmek icin, makine adinin domain adresiyle birlikte duzenlenmesi gerekir
# makine adi "client1" ise "client1.ornek.lab" olarak guncellenir
def editHosts(client_hostname,domain):
    # host dosyasini duzenle
    cmd = subprocess.call("hostnamectl set-hostname " + client_hostname + "." + domain,shell=True)
    cmd = subprocess.Popen("sed -i '/127.0.1.1/d' " + f_hosts,shell=True)
    cmd.communicate()
    cmd = subprocess.Popen("sed -i '1 a\\127.0.1.1      %s.%s   %s' %s" % (client_hostname,domain,client_hostname,f_hosts) ,shell=True)
    cmd.communicate()

# Domaine almak icin, domaindeki yetkili bir kullanici adi
#                                parolasi
#                                domain sunucusunun IP adresi
# gerekmektedir. Bunlari kullanicidan alip main fonksiyona geri dondurur.
def getInputs():
    # Kullanicidan parametreleri al
    domain_ip = raw_input("Samba/AD IP Adresi: ")
    domain_admin = raw_input("Domain admin kullanicisi: ")
    domain_admin_password = getpass.getpass(prompt='Domain admin kullanici parolasi? ') 
    client_hostname = raw_input('Makinenin yeni adi(hostname): ') 
    
    # Domain bilgilerini cek, alinan domain ip adresinden domain ile ilgili diger bilgiler cekilir
    domain_info = subprocess.check_output("samba-tool domain info " + domain_ip + " || true" ,shell=True)
    if domain_info == "":
        exit("Hata: " + domain_ip + " adresinde domain bilgisine ulasilamadi.")
    domain = re.findall("Domain\s*:\s*(.*)", domain_info)[0]
    domain_netbios_name = re.findall("Netbios.*domain\s*:\s*(.*)", domain_info)[0]
    return domain_ip, domain_admin, domain_admin_password, client_hostname, domain, domain_netbios_name

# domain ile haberlesmeyi saglayan bazi servisler ozel karakterleri desteklemez
# Bilgisayari domaine almak ya da domaindeki kullanicilarla giris yapabilmek icin dil ayarlarindan bazilarinin ingilizce olmasi gerekir.
# Dil ayarlarini kalici olarak degistirmek icin /etc/default/locale dosyasini duzenler, mevcut oturum icin dili ingilizceye ceker
def editLocales():
    # İngilizceyi aktiflestirir ve yukler
    cmd = subprocess.Popen("locale-gen", shell=True)
    cmd.communicate()
    # Kalici olarak bazi dil ayarlarini ingilizceye ceker
    cmd = subprocess.Popen("sed -i 's/#.*en_US.UTF-8 UTF-8/en_US.UTF-8 UTF-8/g' /etc/locale.gen" ,shell=True)
    with open("/etc/default/locale", "w") as localefile:
        localefile.write("""LANG=tr_TR.UTF-8
LANGUAGE=
LC_CTYPE="en_US.UTF-8"
LC_NUMERIC="tr_TR.UTF-8"
LC_TIME="tr_TR.UTF-8"
LC_COLLATE="tr_TR.UTF-8"
LC_MONETARY="en_US.UTF-8"
LC_MESSAGES="tr_TR.UTF-8"
LC_PAPER="en_US.UTF-8"
LC_NAME="tr_TR.UTF-8"
LC_ADDRESS="tr_TR.UTF-8"
LC_TELEPHONE="en_US.UTF-8"
LC_MEASUREMENT="en_US.UTF-8"
LC_IDENTIFICATION="en_US.UTF-8"
LC_ALL=""")
    # Mevcut oturumda dil ingilizceye cekilir
    cmd = subprocess.Popen("localectl set-locale LANG=en_US.UTF-8", shell=True)
    cmd.communicate()

# Ticket(bilet) kullanimi icin varsayilan kerberos sunucusu olarak domain sunucusunu ekler
def krbDefaultRealm(domain):
    cmd = subprocess.Popen("sed -i '/default_realm/d' %s" % (f_kerberos),shell=True)
    cmd.communicate()
    cmd = subprocess.Popen("sed -i '/\[libdefaults\]/a default_realm = %s' %s" % (domain,f_kerberos) ,shell=True)
    cmd.communicate()

# Linuxta ev dizini bulunmuyorsa kullanici giris yapamaz. Pam modulune kullanici ilk giris yaparken ev dizini eklenmesi icin bir satir eklenir.
def addMkHomedir():
    if (subprocess.call('grep -w "session required pam_mkhomedir.so skel=\/etc\/skel umask=0077" %s' % ("/etc/pam.d/common-session"),shell=True) == 1):
        subprocess.Popen("echo 'session required pam_mkhomedir.so skel=/etc/skel umask=0077' >> /etc/pam.d/common-session",shell=True)

# Kullanici giris ekraninda tum kullanicilarin cekilmemesi icin
# kullanici adi listesinin drop-down-list olarak degil manuel yazilmasi icin lightdm dosyasinda iki satir yorumdan kaldirilir ve true yapilir
def editLightdmConf():
    if(os.path.isfile(f_ligtdm)):
        cmd = subprocess.Popen("sed -i 's/.*greeter-show-manual-login\s*=\s*false/greeter-show-manual-login=true/g' %s" % (f_ligtdm) ,shell=True)
        cmd.communicate()

        cmd = subprocess.Popen("sed -i 's/.*#greeter-hide-users\s*=\s*false/greeter-hide-users=true/g' %s" % (f_ligtdm) ,shell=True)
        cmd.communicate()

# Domaindeki bulunan "Domain Admins" grubu sudoers dosyasina eklenerek, bu gruba dahil olan tum kullanicilarin makinede 
#   sudo yetkisine sahip olmasi saglanir
def addSudoers(domain):
    with open(f_sudoers, "w") as sudofile:
        sudofile.write("""%s\\x20admins ALL=(ALL) ALL """ % domain)

# Makine domaine alinirken domainde bulunan DNS'e kaydi eklenir. Fakat istemcinin IP adresi degisirse bunun DNS'te guncellenmesi gerekir.
# Network yeniden her baslatildigindan ip adresinin DNS'de guncellenmesini  saglar
def addDNSUpdateOnStart():
    with open(PATH_IFUP, "w") as ifupfile:
        ifupfile.write("""#!/bin/bash
net ads dns register -P""")
    command1="chown root:root "+ PATH_IFUP
    subprocess.Popen(command1, stdout=subprocess.PIPE, shell=True)

# SSSD conf'a linux politikalarin cekilebilmesi icin gerekli bir satir ekler 
def editSSSD():
    subprocess.Popen("rm -f /var/lib/sss/db/*", stdout=subprocess.PIPE, shell=True)
    with open(f_sssd, "a") as sssdfile:
        sssdfile.write("ad_gpo_access_control = permissive")
    subprocess.Popen("systemctl restart sssd", stdout=subprocess.PIPE, shell=True)

# Tum ayarlamalar yapildiktan sonra domaine dahil etme islemi yapilir
def domainJoin(domain_admin_password,domain_admin,domain):
    # Realm komutu ile domaine dahil eder
    command="echo "+ domain_admin_password +" | realm join --user=\""+domain_admin+"@"+domain.upper()+"\" "+domain.lower()
    cmd = subprocess.Popen(command, shell=True)
    cmd.communicate()
    # net ads dns komutu ile makineti domain DNS'ine kaydeder
    command="echo "+ domain_admin_password +" | net ads dns register -U "+domain_admin+"@"+domain.upper()
    cmd = subprocess.Popen(command, shell=True)
    cmd.communicate()

def main():
    # Gereksinimleri yukler
    installDependences()
    # Gerekli bilgileri kullanicidan alir, domain bilgilerini ip adresinden uretir
    domain_ip, domain_admin, domain_admin_password, client_hostname, domain, domain_netbios_name = getInputs()
    
    # Kullanicinin DNS'ini domain sunucusu olarak ayarlar
    editDNS(domain_ip,domain)
    # Sunucu DNS'ine kendisini kaydettirebilmek icin makine adini duzenler
    editHosts(client_hostname,domain)
    # Domain sunucusu ile zamaninin esitler
    setTime(domain_ip)

    # İstemcide bulunan sambanin konfigurasyon dosyasini duzenler 
    addSAMBA(domain_netbios_name,domain)
    # sssd'nin konfigurasyon dosyasini olusturan realmd servisinin ayarlari yapilir
    addREALM(domain)

    # Dil ayarlarindan gerekli olanlari ingilizceye cevirir
    editLocales()

    # Domaine dahil eder ve ip adresini domain DNS'ine ekler
    domainJoin(domain_admin_password,domain_admin,domain)

    # Bilet kullanimi icin gerekli ayarlamalari yapar
    krbDefaultRealm(domain.upper())
    # Kullanicinin ilk girisinde ev dizinini olusturur
    addMkHomedir()
    # Giris ekraninin performansli calismasini saglar
    editLightdmConf()
    # Domain admins grubunu sudoers'e ekler
    addSudoers(domain)
    # IP degisikliginde bunun domain DNS'inde guncellenmesini saglar
    addDNSUpdateOnStart()
    # SSSD ayar dosyasina gerekli ek ayarlari ekler
    editSSSD()

    cmd = subprocess.Popen("realm permit -a", shell=True)
    cmd.communicate()
    
    # BU ISLEMLER TAMAMLANDIKTAN SONRA MAKINE YENIDEN BASLATILMALIDIR

if __name__ == "__main__":
    main()