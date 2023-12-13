using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Hide();
            groupBox1.Hide();
            groupBox2.Hide();
            groupBox3.Hide();
            groupBox4.Hide();
            label9.Hide();
            comboBox3.Hide();
            button2.Hide();
        }
        int adet;
        string isim;
        int toplamtutar1;
        int yfiyat = 0;



        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Show();
            listBox1.Items.Add("****Müşteri Bilgileri****");
            listBox1.Items.Add("Ad: " + textBox1.Text);
            listBox1.Items.Add("Soyad: " + textBox2.Text);
            listBox1.Items.Add("Ödeme şekli: " + comboBox1.Text);
            listBox1.Items.Add("Sipariş No: " + textBox4.Text);
            listBox1.Items.Add("Telefon: " + maskedTextBox1.Text);
            listBox1.Items.Add("Adres: " + textBox3.Text);

            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Text = "";
            textBox4.Clear();
            maskedTextBox1.Clear();
            textBox3.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
         
            Fis fis = new Fis();
            foreach (var item in listBox1.Items)
            {
                fis.listBox1.Items.Add(item);
            }

            fis.listBox1.Items.Add("***YEMEK BİLGİLERİ***");
            if (comboBox2.SelectedItem=="Lahmacun")
            {
            
                fis.listBox1.Items.Add("Yemek: " + comboBox2.SelectedItem.ToString());
                if (checkBox4.Checked==true)
                {
                    adet = Convert.ToInt32(numericUpDown3.Value);                    
                    fis.listBox1.Items.Add(adet + " Adet " + checkBox4.Text);
                    toplamtutar1 += yfiyat * adet;
                }
                if (checkBox3.Checked == true)
                {
                    adet = Convert.ToInt32(numericUpDown4.Value);
                    fis.listBox1.Items.Add(adet + " Adet " + checkBox3.Text);
                    toplamtutar1 += yfiyat * adet;
                }                
            }

            if (comboBox2.SelectedItem == "Pizza")
            {
                fis.listBox1.Items.Add("Yemek: " + comboBox2.SelectedItem.ToString());
                if (checkBox1.Checked == true)
                {
                    adet = Convert.ToInt32(numericUpDown2.Value);
                    fis.listBox1.Items.Add(adet + " Adet " + checkBox1.Text);
                    toplamtutar1 += yfiyat * adet;
                }
                if (checkBox2.Checked == true)
                {
                    adet = Convert.ToInt32(numericUpDown1.Value);
                    fis.listBox1.Items.Add(adet + " Adet " + checkBox2.Text);
                    toplamtutar1 += yfiyat * adet;
                }
            }

            if (comboBox2.SelectedItem == "Kebap")
            {
                fis.listBox1.Items.Add("Yemek: " + comboBox2.SelectedItem.ToString());
                if (checkBox6.Checked == true)
                {
                    adet = Convert.ToInt32(numericUpDown5.Value);
                    fis.listBox1.Items.Add(adet + " Adet " + checkBox6.Text);
                    toplamtutar1 += yfiyat * adet;
                }
                if (checkBox5.Checked == true)
                {
                    adet = Convert.ToInt32(numericUpDown6.Value);
                    fis.listBox1.Items.Add(adet + " Adet " + checkBox5.Text);
                    toplamtutar1 += yfiyat * adet;                   
                }
            }

            fis.listBox1.Items.Add("İçecek: " + comboBox3.SelectedItem + " Fiyat " + ifiyat);
            fis.listBox1.Items.Add("Ödenecek Tutar: " + (toplamtutar1 + ifiyat));
            fis.Show();
            this.Hide();
        }

        
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem.ToString()=="Lahmacun")
            {
                label9.Show();
                comboBox3.Show();
                button2.Show();
                groupBox3.Show();
                groupBox2.Hide();
                groupBox4.Hide();
                yfiyat = 100;

            }
            else if (comboBox2.SelectedItem.ToString() == "Pizza")
            {
                label9.Show();
                comboBox3.Show();
                button2.Show();
                groupBox3.Hide();
                groupBox2.Show();
                groupBox4.Hide();
                yfiyat = 200;
            }
            else if (comboBox2.SelectedItem.ToString() == "Kebap")
            {
                label9.Show();
                comboBox3.Show();
                button2.Show();
                groupBox3.Hide();
                groupBox2.Hide();
                groupBox4.Show();
                yfiyat = 300;
            }
            else
            {
                yfiyat = 0;
            }
        }
        int ifiyat=0;
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedItem.ToString() == "Kola")
            {
                ifiyat = 30;
               
            }
            else if (comboBox3.SelectedItem.ToString() == "Soda")
            {
                ifiyat = 40;
            }
            else if (comboBox3.SelectedItem.ToString() == "Ayran")
            {
                ifiyat = 50;
            }
            else
            {
                ifiyat = 0;
            }
        }
    }
}
