using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Double text1 = Convert.ToDouble(textBox1.Text);
                Double text2 = Convert.ToDouble(textBox2.Text);
                Double sum = text1 + text2;
                label4.Text = sum.ToString();
            }
            catch(Exception)
            {
                MessageBox.Show(" Enter a valid number");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Double text1 = Convert.ToDouble(textBox1.Text);
                Double text2 = Convert.ToDouble(textBox2.Text);
                Double subtract = text1 - text2;
                label4.Text = subtract.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show(" Enter a valid number");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Double text1 = Convert.ToDouble(textBox1.Text);
                Double text2 = Convert.ToDouble(textBox2.Text);
                Double Multiply= text1 * text2;
                label4.Text = Multiply.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show(" Enter a valid number");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Double text1 = Convert.ToDouble(textBox1.Text);
                Double text2 = Convert.ToDouble(textBox2.Text);
                Double Division = text1 / text2;
                label4.Text = Division.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show(" Enter a valid number");
            }
        }
    }
}
