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
    public partial class singup : Form
    {
        dangnhapservict dangnhapservict=new dangnhapservict();
        public singup()
        {
            InitializeComponent();
        }

        private void btn_dangky_Click(object sender, EventArgs e)
        {
            if (dangnhapservict.addacount(tbt_taikhoan.Text, tbt_matkhau.Text) == "them thanh cong")
            {
                MessageBox.Show("dang ky thanh cong");
            }
            else
            {
                MessageBox.Show("dang ky that bai");
            }
        }
    }
}
