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
using ccccc.A_DAL.Models;
using ccccc.A_DAL.repost;
namespace ccccc.view
{
    public partial class manager : Form
    {
       
        sanphamservict sanphamservict = new sanphamservict();   
      
        
        public manager()
        {
            InitializeComponent();
        }
        public void Loadata(List<Product> p)
        {


            dtg_show.Rows.Clear();
            dtg_show.ColumnCount = 5; // Có mấy thuộc tính thì cho bấy nhiêu cột
            dtg_show.Columns[0].Name = "Id";
            dtg_show.Columns[1].Name = "ma san pham  ";
            dtg_show.Columns[2].Name = "ten  ";
            dtg_show.Columns[3].Name = "Giá ";
            dtg_show.Columns[4].Name = "Số lượng";
            dtg_show.Columns[0].Visible = false; // ẨN cột ID đi
            foreach (var item in p)
            {
                dtg_show.Rows.Add(item.Id, item.MaSp, item.ProductName, item.Price,item.Amount);
            }
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn__Click(object sender, EventArgs e)
        {
            Loadata(sanphamservict.showall());
        }

        private void manager_Load(object sender, EventArgs e)
        {
           
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            string masp =tbt_name.Text;
            string name = tbt_name.Text;
            int price = Convert.ToInt32(tbt_price.Text);
            int amount = Convert.ToInt32(tbt_amount.Text);
            MessageBox.Show(sanphamservict.CreateNewsp(masp, name, price, amount));
            Loadata(sanphamservict.showall());
        }

        
        
        private void dtg_show_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbt_msp.Text = dtg_show.CurrentRow.Cells[1].Value.ToString();
            tbt_name.Text = dtg_show.CurrentRow.Cells[2].Value.ToString();
            tbt_price.Text = dtg_show.CurrentRow.Cells[3].Value.ToString();
            tbt_amount.Text = dtg_show.CurrentRow.Cells[4].Value.ToString();
        }
        private void btn_Xoa_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(dtg_show.CurrentRow.Cells[0].Value);
            MessageBox.Show(sanphamservict.DeleteAsp(id));
            Loadata(sanphamservict.showall());

        }

    }
}
