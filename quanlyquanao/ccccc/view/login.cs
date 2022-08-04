using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ccccc.servict;
namespace ccccc.view
{
    public partial class login : Form
    {
        dangnhapservict dangnhapservict=new dangnhapservict();
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(dangnhapservict.dangnhap1(tbt_taikhoan.Text, tbt_matkhau.Text)== "dang nhap thanh cong")
            {
                MessageBox.Show("dang nhap thanh cong");
                manager a = new manager();
                a.ShowDialog();
            }
            else
            {
                MessageBox.Show("tai khoan mat khau khong dung");
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            singup a = new singup();  
            a.ShowDialog();
        }
    }
}
