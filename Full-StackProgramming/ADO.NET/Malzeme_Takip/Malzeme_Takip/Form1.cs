using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Malzeme_Takip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        String kullaniciadi = "admin";
        String sifre = "123";
        int sayac = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text==kullaniciadi && textBox2.Text==sifre)
            {
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
            }
            else
            {
                sayac++;
                MessageBox.Show("Kullanıcı Adınız veya Şifreniz Hatalı! Kalan Deneme Hakkınız: "+(3-sayac),"Hata!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                if (sayac==3)
                {
                    MessageBox.Show("3 kez Hatalı Giriş Yaptınız. Program Sonlandırılıyor");
                    Application.Exit();
                }

            }







        }
    }
}
