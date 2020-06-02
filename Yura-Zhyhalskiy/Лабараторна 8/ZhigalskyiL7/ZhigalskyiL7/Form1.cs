using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZhigalskyiL7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (textBox2.Text)
            {
                case"+":
                    textBox3.Text = (Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox4.Text)).ToString();
                    break;
                case "-":
                    textBox3.Text = (Convert.ToInt32(textBox1.Text) - Convert.ToInt32(textBox4.Text)).ToString();
                    break;
                case "*":
                    textBox3.Text = (Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox4.Text)).ToString();
                    break;
                case "/":
                    textBox3.Text = (Convert.ToDouble(textBox1.Text) / Convert.ToDouble(textBox4.Text)).ToString();
                    break;
                default:
                    MessageBox.Show("Некоректний знак");
                    break;
            }
        }
    }
}
