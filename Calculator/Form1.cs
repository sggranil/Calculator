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
    public partial class Calculator : Form
    {
        double FirstNumber;
        string Operation;
        double SecondNumber;
        double Result;
        public Calculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void b1_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0" && textBox.Text != null)
            {
                textBox.Text = "1";
            } 
            else 
            {
                textBox.Text = textBox.Text + "1";
            }
        }

        private void b2_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0" && textBox.Text != null)
            {
                textBox.Text = "2";
            }
            else
            {
                textBox.Text = textBox.Text + "2";
            }
        }

        private void b3_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0" && textBox.Text != null)
            {
                textBox.Text = "3";
            }
            else
            {
                textBox.Text = textBox.Text + "3";
            }
        }

        private void b4_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0" && textBox.Text != null)
            {
                textBox.Text = "4";
            }
            else
            {
                textBox.Text = textBox.Text + "4";
            }
        }

        private void b5_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0" && textBox.Text != null)
            {
                textBox.Text = "5";
            }
            else
            {
                textBox.Text = textBox.Text + "5";
            }
        }

        private void b6_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0" && textBox.Text != null)
            {
                textBox.Text = "6";
            }
            else
            {
                textBox.Text = textBox.Text + "6";
            }
        }

        private void b7_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0" && textBox.Text != null)
            {
                textBox.Text = "7";
            }
            else
            {
                textBox.Text = textBox.Text + "7";
            }
        }

        private void b8_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0" && textBox.Text != null)
            {
                textBox.Text = "8";
            }
            else
            {
                textBox.Text = textBox.Text + "8";
            }
        }

        private void b9_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0" && textBox.Text != null)
            {
                textBox.Text = "9";
            }
            else
            {
                textBox.Text = textBox.Text + "9";
            }
        }

        private void bDot_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + ".";
        }

        private void b0_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "0";
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox.Text);
            textBox.Text = "0";
            Operation = "+";
        }

        private void bEqual_Click(object sender, EventArgs e)
        {

                SecondNumber = Convert.ToDouble(textBox.Text);

                if (Operation == "+")
                {
                    Result = (FirstNumber + SecondNumber);
                    textBox.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                }
                if (Operation == "-")
                {
                    Result = (FirstNumber - SecondNumber);
                    textBox.Text = Convert.ToString(Result);
                    FirstNumber = Result;
            }
                if (Operation == "*")
                {
                    Result = (FirstNumber * SecondNumber);
                    textBox.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                }
                if (Operation == "/")
                {
                    if (SecondNumber == 0)
                    {
                        textBox.Text = "Cannot divide by zero";

                    }
                    else
                    {
                        Result = (FirstNumber / SecondNumber);
                        textBox.Text = Convert.ToString(Result);
                        FirstNumber = Result;
                    }
                }
        }

        private void bMin_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox.Text);
            textBox.Text = "0";
            Operation = "-";
        }

        private void bMul_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox.Text);
            textBox.Text = "0";
            Operation = "*";
        }

        private void bDiv_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox.Text);
            textBox.Text = "0";
            Operation = "/";
        }

        private void bc_Click(object sender, EventArgs e)
        {
            textBox.Text = "0";
        }

        private void bSqr_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox.Text);
            Result = Math.Sqrt(FirstNumber);
            textBox.Text = Convert.ToString(Result);
            FirstNumber = Result;
        }

        private void bAbs_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox.Text);
            Result = Math.Abs(FirstNumber);
            textBox.Text = Convert.ToString(Result);
            FirstNumber = Result;
        }

        private void bDel_Click(object sender, EventArgs e)
        {
            if (textBox.TextLength > 0)
            {
                textBox.Text = textBox.Text.Substring(0, (textBox.TextLength - 1));
            }
            
            if (textBox.TextLength == 0)
            {
                textBox.Text = "0";
            }
        }
    }
}
