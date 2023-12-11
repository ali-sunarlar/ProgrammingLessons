using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uygulama4_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked==true)
            {
                listBox1.Items.Add("Medeni Durum: "+radioButton1.Text);
            }
            else
            {
                listBox1.Items.Add("Medeni Durum: "+radioButton2.Text);
            }
            if(checkBox1.Checked == true && checkBox2.Checked == true)
            {
                listBox1.Items.Add("Ehliyet Durumu: "+checkBox1.Text);
                listBox1.Items.Add("Ehliyet Durumu: " + checkBox2.Text);
            }
            else if(checkBox1.Checked == true)
            {
                listBox1.Items.Add("Ehliyet Durumu: " + checkBox1.Text);
            }
            else if(checkBox2.Checked==true)
            {
                listBox1.Items.Add("Ehliyet Durumu: " + checkBox2.Text);
            
            }


        }
    }
}
