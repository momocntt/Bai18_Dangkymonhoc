using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai18_Dangkymonhoc
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbxNienkhoa.Items.Add("2020");
            cbxNienkhoa.Items.Add("2021");
            cbxNienkhoa.Items.Add("2022");
            cbxNienkhoa.Items.Add("2023");
            cbxNienkhoa.Items.Add("2024");
            cbxNienkhoa.Items.Add("2025");
            cbxNienkhoa.SelectedIndex = 0;

            cbxLop.Items.Add(" Ứng dụng phần mềm 1 ");
            cbxLop.Items.Add(" Ứng dụng phần mềm 2 ");
            cbxLop.Items.Add(" Thiết kế đồ họa 1 ");
            cbxLop.Items.Add(" Thiết kế đồ họa 2 ");
            cbxLop.Items.Add(" Quản trị mạng 1 ");
            cbxLop.Items.Add(" Quản trị mạng 2 ");
            cbxLop.SelectedIndex = 0;

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMssv.Clear();
            txtTen.Clear();
        }

        private void btnDk_Click(object sender, EventArgs e)
        {
            string thongtin;
            string hovaten;
            thongtin = "Mã số sinh viên: " + txtMssv.Text;
            hovaten = " Họ và tên: " + txtTen.Text;
            string hocky = "";
            if (radI.Checked)
            {
                hocky = radI.Text;
            }
            else if (radIi.Checked)
            {
                hocky = radIi.Text;
            }
            else if (radIii.Checked)
            {
                hocky = radIii.Text;
            }
            else if (radIv.Checked)
            {
                hocky = radIv.Text;
            }
            thongtin += "\nĐã đăng ký học kỳ " + hocky + " các môn học sau:";

            int stt = 1;
            foreach (var item in clbMonhoc.CheckedItems)
            {
                thongtin += "\n" + stt + ". " + item.ToString();
                stt++;
            }
            MessageBox.Show(thongtin, "Thông tin sinh viên ");
        }    
        }
    }

