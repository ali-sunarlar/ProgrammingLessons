using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uygulama5_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "Türk Kahvesi")
            {
                groupBox1.Visible = true;
                groupBox2.Visible = false;
                groupBox3.Visible = false;
                int fiyat = 50;
                textBox1.Text=fiyat.ToString();
            }
            else if (comboBox1.SelectedItem == "Latte")
            {
                groupBox1.Visible = false;
                groupBox2.Visible = true;
                groupBox3.Visible = false;
                int fiyat = 60;
                textBox2.Text = fiyat.ToString();
            }
            else if (comboBox1.SelectedItem == "Filtre")
            {
                groupBox1.Visible = false;
                groupBox2.Visible = false;
                groupBox3.Visible = true;
                int fiyat = 70;
                textBox3.Text = fiyat.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Fatura.Visible = true;
            if(comboBox1.SelectedItem=="Türk Kahvesi")
            {
                Fatura.Items.Add("Kahve : " + comboBox1.SelectedItem);
                Fatura.Items.Add("Fiyat : " + textBox1.Text);
            }
            else if(comboBox1.SelectedItem =="Latte")
            {
                Fatura.Items.Add("Kahve: " + comboBox1.SelectedItem);
                Fatura.Items.Add("Fiyat: " + textBox2.Text);
            }
            else
            {
                Fatura.Items.Add("Kahve: " + comboBox1.SelectedItem);
                Fatura.Items.Add("Fiyat: " + textBox3.Text);
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            Fatura.Visible = false;
        }
    }
}
