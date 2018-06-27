using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        double num1,num2;
        String work;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void n1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null) //Checks whether if it is the first letter
                textBox1.Text = "1";  //Replaces it with the button pressed
            else
                textBox1.Text += "1";   //adds it along with the element present
        }

        private void n2_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "0" && textBox1.Text != null)
                textBox1.Text = "2";
            else
                textBox1.Text += "2";
        }

        private void n3_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "0" && textBox1.Text != null)
                textBox1.Text = "3";
            else
                textBox1.Text += "3";
        }

        private void n4_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "0" && textBox1.Text != null)
                textBox1.Text = "4";
            else
                textBox1.Text += "4";
        }

        private void n5_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "0" && textBox1.Text != null)
                textBox1.Text = "5";
            else
                textBox1.Text += "5";
        }

        private void n6_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "0" && textBox1.Text != null)
                textBox1.Text = "6";
            else
                textBox1.Text += "6";
        }

        private void n7_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "0" && textBox1.Text != null)
                textBox1.Text = "7";
            else
                textBox1.Text += "7";
        }

        private void n8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
                textBox1.Text = "8";
            else
                textBox1.Text += "8";

        }

        private void n9_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "0" && textBox1.Text != null)
                textBox1.Text = "9";
            else
                textBox1.Text += "9";
        }

        private void n0_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "0" && textBox1.Text != null)
                textBox1.Text = "0";
            else
                textBox1.Text += "0";

        }

        private void clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            num1 = 0;
            num2 = 0;
        }

        private void add_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            work = "+";
            textBox1.Text = "0";
        }

        private void sub_Click(object sender, EventArgs e)
        {

            num1 = Convert.ToDouble(textBox1.Text);
            work = "-";
            textBox1.Text = "0";
        }

        private void mul_Click(object sender, EventArgs e)
        {

            num1 = Convert.ToDouble(textBox1.Text);
            work = "*";
            textBox1.Text = "0";
        }

        private void div_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            work = "/";
            textBox1.Text = "0";
        }

        private void ans_Click(object sender, EventArgs e)
        {
            double result;
            num2 = Convert.ToDouble(textBox1.Text);
            switch (work)
            {
                case "+":
                    {
                        result = num1 + num2;
                        textBox1.Text = Convert.ToString(result);//Display Result by converting it to string
                        num1 = result; break;  //For further processing
                    }
                case "-":
                    {
                        result = num1 - num2;
                        textBox1.Text = Convert.ToString(result);//Display Result by converting it to string
                        num1 = result; break;  //For further processing
                    }
                case "*":
                    {
                        result = num1 * num2;
                        textBox1.Text = Convert.ToString(result);//Display Result by converting it to string
                        num1 = result; break;  //For further processing
                    }
                case "/":
                    {
                           if (num2 == 0)
                            textBox1.Text = "by zero division error, change the second value";
                        result = num1 / num2;
                        textBox1.Text = Convert.ToString(result);//Display Result by converting it to string
                        num1 = result; break;  //For further processing
                    }
            }
        }
    }
}