using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example01
{
    public partial class cau4 : Form
    {
        decimal workingMemory = 0;
        string opr = "";
        decimal memory = 0;

        public cau4()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;


            if ((char.IsDigit(bt.Text, 0) && bt.Text.Length == 1) || bt.Text == ".")
            {
                textBox1.Text += bt.Text;
            }

            else if (bt.Text == "+" || bt.Text == "-" || bt.Text == "*" || bt.Text == "/")
            {
                opr = bt.Text;
                workingMemory = decimal.Parse(textBox1.Text);
                textBox1.Clear();
            }

            else if (bt.Text == "=")
            {
                decimal secondValue = decimal.Parse(textBox1.Text);
                if (opr == "+")
                {
                    textBox1.Text = (workingMemory + secondValue).ToString();
                }
                else if (opr == "-")
                {
                    textBox1.Text = (workingMemory - secondValue).ToString();
                }
                else if (opr == "*")
                {
                    textBox1.Text = (workingMemory * secondValue).ToString();
                }
                else if (opr == "/")
                {
                    if (secondValue != 0)
                    {
                        textBox1.Text = (workingMemory / secondValue).ToString();
                    }
                    else
                    {
                        MessageBox.Show("Không thể chia cho 0.");
                    }
                }
            }

            else if (bt.Text == "±")
            {
                decimal currVal = decimal.Parse(textBox1.Text);
                currVal = -currVal;
                textBox1.Text = currVal.ToString();
            }

            else if (bt.Text == "√")
            {
                decimal currVal = decimal.Parse(textBox1.Text);
                currVal = (decimal)Math.Sqrt((double)currVal);
                textBox1.Text = currVal.ToString();
            }

            else if (bt.Text == "%")
            {
                decimal currVal = decimal.Parse(textBox1.Text);
                currVal = currVal / 100;
                textBox1.Text = currVal.ToString();
            }

            else if (bt.Text == "1/x")
            {
                decimal currVal = decimal.Parse(textBox1.Text);
                if (currVal != 0)
                {
                    currVal = 1 / currVal;
                    textBox1.Text = currVal.ToString();
                }
                else
                {
                    MessageBox.Show("Không thể chia cho 0.");
                }
            }

            else if (bt.Text == "<-")
            {
                if (textBox1.TextLength != 0)
                {
                    textBox1.Text = textBox1.Text.Remove(textBox1.TextLength - 1);
                }
            }

            else if (bt.Text == "MC")
            {
                memory = 0;
            }
            else if (bt.Text == "MR")
            {
                textBox1.Text = memory.ToString();
            }
            else if (bt.Text == "MS")
            {
                memory = decimal.Parse(textBox1.Text);
                textBox1.Clear();
            }
            else if (bt.Text == "M+")
            {
                memory += decimal.Parse(textBox1.Text);
            }
            else if (bt.Text == "M-")
            {
                memory -= decimal.Parse(textBox1.Text);
            }

            else if (bt.Text == "C")
            {
                workingMemory = 0;
                opr = "";
                textBox1.Clear();
            }

            else if (bt.Text == "CE")
            {
                textBox1.Clear();
            }
        }

    }
}