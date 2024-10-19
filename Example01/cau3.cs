using System;
using System.Collections;
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
    public partial class cau3 : Form
    {
        public cau3()
        {
            InitializeComponent();
        }
        
        private void cau3_Load(object sender, EventArgs e)
        {
            ArrayList lst = GetData();
            cb_Faculty.DataSource= lst;
            cb_Faculty.DisplayMember = "Name";
            cb_Faculty.ValueMember = "Id";


        }

        private void cb_Faculty_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cb_Faculty.SelectedValue != null)
            {
                string id = cb_Faculty.SelectedValue.ToString();
                tbDisplay.Text = "Bạn đã chọn khoa có mã: " + id;
            }
        }

        private void btOK_Click(object sender, EventArgs e)
{
    if (cb_Faculty.SelectedItem != null)
    {
        Faculty selectedFaculty = (Faculty)cb_Faculty.SelectedItem; // Lấy đối tượng Faculty đã chọn
        tbDisplay.Text = "Bạn đã chọn khoa có tên: " + selectedFaculty.Name+ "\r\n" + "Mã: " + selectedFaculty.Id+ "\r\n" + "Số lượng: " + selectedFaculty.Quantity;
    }
}
        public ArrayList GetData()
        {
            ArrayList lst = new ArrayList();

            Faculty f = new Faculty();
            f.Id = "K01";
            f.Name = "Công nghệ thông tin";
            f.Quantity = 1200;
            lst.Add(f);

            f = new Faculty();
            f.Id = "K02";
            f.Name = "Quản trị kinh doanh";
            f.Quantity = 4200;
            lst.Add(f);

            f = new Faculty();
            f.Id = "K03";
            f.Name = "Điện";
            f.Quantity = 5200;
            lst.Add(f);

            f = new Faculty();
            f.Id = "K04";
            f.Name = "Ngoại ngữ";
            f.Quantity = 2200;
            lst.Add(f);

            f = new Faculty();
            f.Id = "K05";
            f.Name = "Cơ khí động lực";
            f.Quantity = 3200;
            lst.Add(f);

            f = new Faculty();
            f.Id = "K06";
            f.Name = "Cơ khí";
            f.Quantity = 6200;
            lst.Add(f);
            return lst;


        }
    }
}
