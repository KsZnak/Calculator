using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public string firstnumber;
        public int result;
        public string secondnumber;
        public string text;
        public int firstnumberint;
        public int secondnumberint;
        public bool eventplus;
        public Form1()
        {
            InitializeComponent();
           

    }

        private void button9_Click(object sender, EventArgs e)
        {
            int b1 = 1;
            textBox1.Text = textBox1.Text +  b1 ;

        }

        private void button10_Click(object sender, EventArgs e)
        {
            int b2 = 2;
            textBox1.Text = textBox1.Text + b2;

        }

        private void button11_Click(object sender, EventArgs e)
        {
            int b3 = 3;
            textBox1.Text = textBox1.Text + b3;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int b4 = 4;
            textBox1.Text = textBox1.Text + b4;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int b5 = 5;
            textBox1.Text = textBox1.Text + b5;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int b6 = 6;
            textBox1.Text = textBox1.Text + b6;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int b7 = 7;
            textBox1.Text = textBox1.Text + b7;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int b8 = 8;
            textBox1.Text = textBox1.Text + b8;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int b9 = 9;
            textBox1.Text = textBox1.Text + b9;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            
            textBox1.Text = null;
        }

        private void button4_Click(object sender, EventArgs e)
        {

            
            textBox2.Text = textBox1.Text  + " + ";
           
            text = textBox2.Text;
            firstnumber = textBox1.Text;
            firstnumberint = Convert.ToInt32(firstnumber);
            textBox1.Text = null;
            eventplus = true;
           


        }

        private void button15_Click(object sender, EventArgs e)
        {
            
            secondnumber = textBox1.Text;
            textBox2.Text = text + textBox1.Text;
            secondnumberint = Convert.ToInt32(secondnumber);

            if (eventplus)
            {

                result = firstnumberint + secondnumberint;
                textBox1.Text = result + "";
            }
            else

                result = 0; 

        }

        private void button13_Click(object sender, EventArgs e)
        {
            int b0 = 0;
            textBox1.Text =  b0 + textBox1.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }
    }
}
