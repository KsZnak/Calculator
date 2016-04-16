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
        public string secondnumber;
        public string text;
        public double result;
        public double firstnumberdouble;
        public double secondnumberdouble;
        public bool eventplus;
        public bool eventminus;
        public bool eventmultiply;
        public bool eventshare;
        public Form1()
        {
            InitializeComponent();

        }

        //создаем события в TextBox при нажатии кнопки (цыфры)

        private void button9_Click(object sender, EventArgs e)
        {
         
            textBox1.Text = textBox1.Text + "1" ;

        }

        private void button10_Click(object sender, EventArgs e)
        {
            
            textBox1.Text = textBox1.Text + "2";

        }

        private void button11_Click(object sender, EventArgs e)
        {
            
            textBox1.Text = textBox1.Text + "3";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            textBox1.Text = textBox1.Text + "4";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            textBox1.Text = textBox1.Text + "5";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            textBox1.Text = textBox1.Text + "7";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            textBox1.Text = textBox1.Text + "8";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            textBox1.Text = textBox1.Text + "9";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            
            textBox1.Text = textBox1.Text + "0";
        }


        private void button17_Click(object sender, EventArgs e)
        {
            
            textBox1.Text = null;
            textBox2.Text = null;
            result = 0;
            
        }


        private void button8_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text + " - ";
            text = textBox2.Text;
            firstnumber = textBox1.Text;
            firstnumberdouble = Convert.ToDouble(firstnumber);
            textBox1.Text = null;
            eventplus = false;
            eventminus = true;
            eventmultiply = false;
            eventshare = false;
        }


        private void button4_Click(object sender, EventArgs e)
        {


            textBox2.Text = textBox1.Text + " + ";

            text = textBox2.Text;
            firstnumber = textBox1.Text;
            firstnumberdouble = Convert.ToDouble(firstnumber);
            textBox1.Text = null;
            eventplus = true;
            eventminus = false;
            eventmultiply = false;
            eventshare = false;



        }

        private void button15_Click(object sender, EventArgs e)
        {
            
            secondnumber = textBox1.Text;
            textBox2.Text = text + textBox1.Text;
            firstnumberdouble = Convert.ToDouble(secondnumber);

            if (eventplus)
            {

                result = Convert.ToDouble(firstnumber) + Convert.ToDouble(secondnumber);
                textBox1.Text = result + "";
                textBox2.Text = textBox2.Text + " = " + textBox1.Text;
            }
            else

                result = 0;
            
            
            

            if (eventminus)
            {

                result = Convert.ToDouble(firstnumber) - Convert.ToDouble(secondnumber);
                textBox1.Text = result + "";
                textBox2.Text = textBox2.Text + " = " + textBox1.Text;
                
            }
            else
                result = 0;
            

            if (eventmultiply)
            {

                result = Convert.ToDouble(firstnumber) * Convert.ToDouble(secondnumber);
                textBox1.Text = result + "";
                textBox2.Text = textBox2.Text + " = " + textBox1.Text;
                

            }
            else
                result = 0;

            if (eventshare)
            {

                result = Convert.ToDouble(firstnumber) / Convert.ToDouble(secondnumber);
                textBox1.Text = result + "";
                textBox2.Text = textBox2.Text + " = " + textBox1.Text;
                

            }
            else
                result = 0;


        }

     
        private void button12_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text + " * ";

            text = textBox2.Text;
            firstnumber = textBox1.Text;
            firstnumberdouble = Convert.ToDouble(firstnumber);
            textBox1.Text = null;
            eventplus = false;
            eventminus = false;
            eventmultiply = true;
            eventshare = false;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text + " / ";

            text = textBox2.Text;
            firstnumber = textBox1.Text;
            firstnumberdouble = Convert.ToDouble(firstnumber);
            
            textBox1.Text = null;
            eventplus = false;
            eventminus = false;
            eventmultiply = false;
            eventshare = true;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ",";
        }
    }
}
