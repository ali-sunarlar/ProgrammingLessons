#!/usr/bin/python
# -*- coding: utf-8 -*-
# sudo apt-get install libsasl2-dev python-dev libldap2-dev libssl-dev
import json, datetime, os, sys, ldap
from ldap.controls import SimplePagedResultsControl
import ldap.modlist as modlist

server_ip_adress = "192.168.132.131"
domain_dot_format = "ornek.ldap.com"
## split "." lara gore metni parcalar, aralara ",dc=" koyarak join ile parcalari birlestirir
domain_dc_format = "dc=" + ",dc=".join(domain_dot_format.split("."))
port = "389"
user_dn = "cn=admin,dc=ornek,dc=ldap,dc=com"
password = "Password!"

# Samba baglantisi kurulur. Global degiskene atanir. Sistemin her yerinden erisilebilir
def setSambaConnection():
    print("setSambaConnection")
    global ldap_connection
    ## try icersisnde herhangibir hata alinirsa except kisminda cikti olarak hatayi yazdirir
    try:
        host =  server_ip_adress + ':' + port
        ## varsayilan olarak openldap guvensiz olan ldap(389), samba ldaps(636)'i kullanir.
        if port == "389":
            host = 'ldap://' + host
        elif port == "636":
            host = 'ldaps://' + host
        ldap.set_option(ldap.OPT_X_TLS_REQUIRE_CERT, ldap.OPT_X_TLS_NEVER)
        ldap_connection = ldap.initialize(host)
        ldap_connection.protocol_version = ldap.VERSION3
        ldap_connection.set_option(ldap.OPT_REFERRALS, 0)
        ldap_connection.set_option(ldap.OPT_NETWORK_TIMEOUT, 20.0)
        ldap_connection.simple_bind_s(user_dn, password)
    except Exception as e:
        ## Baglantida hata aldiysa ekrana cikti verir ve programi kapatir
        print("Samba/AD sunucusuna baglanamadi")
        sys.exit(e)
    ## Hata alnadiysa ekrana cikti verir
    print("Samba/AD sunucusuna baglandi")



# Daha once kurulan baglanti global olarak tanimlanir. Kullanici adi ve soyadi alarak basit bir kullanici ekler.
def addUser(username,surname):
    global ldap_connection
    # dn ile birlikte verinin tam yolu belirlenir
    dn = "uid=" + username + ",ou=kisiler," + domain_dc_format
    # modlist ile nesnenin ozellikleri (sinifinin semasina gore) veri listesi oluşturulur
    modlist = {
        "objectClass": ["inetOrgPerson"], # Sinifi inetOrgPerson, hangi ozelliklere sahip olacagini belirtir
        "cn": [ username ],               # Nesneye verilen isim (tc ya da isim verilebilir)
        "sn": [ surname ],                # soyadi
        }
    # oluşdurulan ozellik listesi ile, belirtilen dn'de ldap modulundeki add_s fonksiyonu ile kullanici eklenir
    result = ldap_connection.add_s(dn, ldap.modlist.addModlist(modlist))

# yukarudaki fonksiyon ile ayni işi yapar. 1 yerine 100 kullanici ekler
def addMoreUser(username,surname):
    global ldap_connection
    dn = "uid=" + username + ",ou=kisiler," + domain_dc_format
    for number in range(100):
        modlist = {
            "objectClass": ["inetOrgPerson"],
            "cn": [ username+str(number) ],
            "sn": [ surname+str(number) ],
            }
        result = ldap_connection.add_s(dn, ldap.modlist.addModlist(modlist))

# Basit bir sorgu yapar
#   filter hengi verilerin aranacagi (orneğin kullanicilar ve telefon numarasi bos olmayanlar)
#   attrs hangi ozelliklerin cekileceği (adi ve soyadi)
#   base_dn aramanin agacin neresinde yapilacagini belirtir
def search(filter,attrs,base_dn):
    global ldap_connection
    result = ldap_connection.search_s(base_dn, ldap.SCOPE_SUBTREE, filter, attrs)
    print(result)
    # donen dictionary array'indeki verileri for donerek daha basit bir hale getirir. Key olarak kullanilar dn'leri siler
    results = [entry for dn, entry in result if isinstance(entry, dict)]
    print results
    return results

# Ldap sorgusunda 1000'den fazla veri sorgu cok uzun surer ya da limit asildi seklinde hata verir.
# Bu fonksiyon donen sorgunun ciktilarini biner biner alir, birbirinin sonuna ekler.
#   filter hengi verilerin aranacagi (orneğin kullanicilar ve telefon numarasi bos olmayanlar)
#   attrs hangi ozelliklerin cekileceği (adi ve soyadi)
#   base_dn aramanin agacin neresinde yapilacagini belirtir
def getSambaUsers(filter,attrs,base_dn):
    print("getSambaUsers")
    global ldap_connection
    ldapUsers = []
    page_control = SimplePagedResultsControl(True, size=1000, cookie='')

    response = ldap_connection.search_ext(base_dn,ldap.SCOPE_SUBTREE,filter,attrs,serverctrls=[page_control])
    try:
        pages = 0
        while True:
            pages += 1
            rtype, rdata, rmsgid, serverctrls = ldap_connection.result3(response)
            ldapUsers.extend(rdata)
            controls = [control for control in serverctrls if control.controlType == SimplePagedResultsControl.controlType]
            if not controls:
                print('The server ignores RFC 2696 control')
                break
            if not controls[0].cookie:
                break
            page_control.cookie = controls[0].cookie
            response = ldap_connection.search_ext(base_dn,ldap.SCOPE_SUBTREE,filter, attrs,serverctrls=[page_control])

    except:
        print()

    # donen dictionary array'indeki verileri for donerek daha basit bir hale getirir. Key olarak kullanilar dn'leri siler
    results = [entry for dn, entry in ldapUsers if isinstance(entry, dict)]
    return results

def main():
    ## Define Globals
    global ldap_connection

    # ldap baglantisi kurar. bunu ldap_connection degiskenine atar
    setSambaConnection()
    

if __name__ == '__main__':
    sys.exit(main())