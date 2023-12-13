using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer_Ornek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string giriszamani=DateTime.Now.ToLongTimeString();
            string cikiszamani = "10:30";
            TimeSpan giriscikisfarki = DateTime.Parse(cikiszamani).Subtract(DateTime.Parse(giriszamani));
            string calismasuresi = giriscikisfarki.ToString();
            label1.Text = calismasuresi;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
