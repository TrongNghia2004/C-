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

    public partial class cau_1 : Form
    {
       
        private int stt = 1;
        
        public cau_1()
        {
            InitializeComponent();
            this.Text = "Quản lý sinh viên"; // Set form title
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string hoTen = textBox1.Text;               // Họ và tên từ TextBox
            string ngaySinh = dateTimePicker1.Value.ToString("dd/MM/yyyy");      // Ngày sinh từ DateTimePicker
            string khoa = comboBox1.SelectedItem?.ToString(); // Khoa từ ComboBox (nếu có)
            //gioi tinh
            string msg = null;
            int disc = 0;
            if (radioButton1.Checked == true)
                msg += "Nam ";
            if (radioButton2.Checked == true)
                msg += "Nữ ";
            //
            
            listBox1.Items.Add($"{stt}.Họ và tên: {hoTen}");
            stt++;
            listBox1.Items.Add($"   Ngày sinh: {ngaySinh}");
            listBox1.Items.Add($"   Giới tính: {msg}");
            listBox1.Items.Add($"   Khoa: {khoa}");
            listBox1.Items.Add("--------------------");
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
