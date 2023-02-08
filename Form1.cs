using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kişi_bilgisi_kayıt_defteri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label8.Text  = textBox1.Text;
            label10.Text = textBox2.Text;
            label12.Text = textBox3.Text;
            label14.Text = textBox4.Text;
            label16.Text = comboBox1.Text;
            label19.Text = textBox5.Text;

        }
    }
}
