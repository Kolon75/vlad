using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c, d;

            a = double.Parse(textBox1.Text);
            b = double.Parse(textBox2.Text);
            c = double.Parse(textBox3.Text);

            d = b*b - 4*a*c;
            MessageBox.Show(d.ToString());
            if (d > 0)
            {
                
                label2.Text = $"x1 = {(-b + Math.Sqrt(d)) / (2 * a)}, x2 = {(-b - Math.Sqrt(d))/ (2 * a)}";
                
            }
            if (d < 0)
            {
                label2.Text = "Корней не существует";
            }
            if (d == 0)
            {
                label2.Text = $"x1 = {-b /(2 * a)}";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }
    }
}