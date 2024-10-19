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
    public partial class cau2 : Form
    {
        public cau2()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string msg = null;
            int disc = 0;
            if (radioButton1.Checked == true)
                msg += "Ông ";
            if (radioButton2.Checked == true)
                msg += "Bà ";
            if (checkBox1.Checked == true)
                disc = 7;
            textBox3.Text = msg + textBox1.Text + " được giảm " + disc.ToString() + "%" + "\r\n";

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
