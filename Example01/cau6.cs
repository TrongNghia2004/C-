using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Example01
{
    public partial class cau6 : Form
    {
        decimal workingMemory = 0;
        string opr = "";
        public cau6()
        {
            InitializeComponent();
        }

        private void bt0_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += bt0.Text;
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += bt1.Text;
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += bt2.Text;
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += bt3.Text;
        }

        private void btMul_Click(object sender, EventArgs e)
        {
            opr = "+";
            workingMemory = decimal.Parse(tbDisplay.Text);
            tbDisplay.Clear();

        }

        private void btEquals_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbDisplay.Text))
            {
                opr = "*";
                workingMemory = decimal.Parse(tbDisplay.Text);
                tbDisplay.Clear();
            }
        }

        private void btPlus_Click(object sender, EventArgs e)
        {
            if (!tbDisplay.Text.Contains("."))
            {
                tbDisplay.Text += ".";
            }
        }

        private void btKetQua_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbDisplay.Text))
            {

                decimal secondValue = decimal.Parse(tbDisplay.Text);

                if (opr == "*")
                {
                    tbDisplay.Text = (workingMemory * secondValue).ToString();
                }
                else if (opr == "+")
                {
                    tbDisplay.Text = (workingMemory + secondValue).ToString();
                }

                workingMemory = 0;
                opr = "";
            }
        }



    }
}