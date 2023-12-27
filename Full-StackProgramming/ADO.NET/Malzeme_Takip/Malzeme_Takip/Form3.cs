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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String malzemekodu = textBox1.Text;
            String malzemeadi = textBox2.Text;
            String birim = comboBox1.Text;
            String birimfiyat = textBox3.Text;
            String tedarikci = textBox4.Text;

            label11.Text= malzemekodu;
            label12.Text= malzemeadi;
            label13.Text= birim;
            label14.Text= birimfiyat;
            label15.Text= tedarikci;

            groupBox1.Visible = true;

            if(checkBox1.Checked==true)
            {
                MessageBox.Show("Yeni malzeme bilgisi başarılı bir şekilde kayıt edilmiştir.");
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text,"[^0-9]"))
            {
                MessageBox.Show("Lütfen Sadece Rakam Giriniz!");
                textBox1.Text=textBox1.Text.Remove(textBox1.Text.Length-1);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox3.Text, "[^0-9]"))
            {
                MessageBox.Show("Lütfen Sadece Rakam Giriniz!");
                textBox3.Text = textBox3.Text.Remove(textBox3.Text.Length - 1);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox2.Text, "[^A-z]"))
            {
                MessageBox.Show("Lütfen Sadece Harf Giriniz!");
                textBox2.Text = "";
            }

        }
    }
}
