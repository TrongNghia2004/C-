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
    public partial class cau5 : Form
    {
        public cau5()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        

        private void tbSoX_TextChanged(object sender, EventArgs e)
        {

        }

        private void btCong_Click(object sender, EventArgs e)
        {
            tbKetQua.Clear();
            int x = int.Parse(tbSoX.Text);
            int y = int.Parse(tbSoY.Text);
            int kq = x + y;
            tbKetQua.Text = tbKetQua.Text + x.ToString() + " + " + y.ToString() + " = " + kq.ToString();

        }

        private void btNhan_Click(object sender, EventArgs e)
        {
            tbKetQua.Clear();
            int x = int.Parse(tbSoX.Text);
                int y = int.Parse(tbSoY.Text);
                int kq = x * y;
                tbKetQua.Text = tbKetQua.Text + x.ToString() + " * " + y.ToString() + " = " + kq.ToString();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(@"D:\LUONG TRONG NGHIA - 2122110139\luongtrongnghia\Caculator.txt", true);
            sw.Write(tbKetQua.Text);
            sw.Close();
        }
    }
}
