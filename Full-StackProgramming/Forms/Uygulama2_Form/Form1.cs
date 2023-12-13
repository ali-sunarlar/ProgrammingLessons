using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uygulama2_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1=Convert.ToInt32(textBox1.Text);
            int sayi2=Convert.ToInt32(textBox2.Text);
            string islem = textBox3.Text;

            if(islem =="+")
            {
                label4.Text = "Toplam Sonucu: ";
                int toplam = sayi1 + sayi2;
                label5.Text=toplam.ToString();
            }
            else if(islem =="-")
            {
                label4.Text = "Çıkarma Sonucu: ";
                label5.Text=(sayi1-sayi2).ToString();
            }
            else if (islem == "*")
            {
                label4.Text = "Çarpım Sonucu: ";
                label5.Text = (sayi1 * sayi2).ToString();

            }
            else if (islem == "/")
            {
                label4.Text = "Bölme Sonucu: ";
                label5.Text = (sayi1 / sayi2).ToString();

            }
            else
            {
                MessageBox.Show("Sadece 4 İşlem Yapılır!");
            }


        }
    }
}
