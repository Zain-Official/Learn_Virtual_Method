using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Learn_Virtual_Method
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                CalTax ct = new CalTax();
                ct.Calculate_Tax(Convert.ToInt32(textBox1.Text));
                textBox2.Text = ct.gettax.ToString();
                textBox3.Text = ct.getslab;
            }
            else
            {
                Tax t = new Tax();
                t.Calculate_Tax(Convert.ToInt32(textBox1.Text));
                textBox2.Text = t.gettax.ToString();
                textBox3.Text = t.getslab;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
