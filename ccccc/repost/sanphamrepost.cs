using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ccccc.A_DAL.Models;
namespace ccccc.A_DAL.repost
{
    
    internal class sanphamrepost
    {
        qlbh1Context qlbhContext = new qlbh1Context();
        public List<Product> GetProducts()
        {
            return qlbhContext.Products.ToList();
        }
        public bool Addsanpham(Product c) // thêm mới 1 xe
        {
            try
            {
                qlbhContext.Products.Add(c); qlbhContext.SaveChanges(); // Thêm và lưu thay đổi
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message); return false;
            }
        }
        public bool deletesp(int id) // Xóa 1 xe được lựa chọn
        {
            try
            {
                var car = qlbhContext.Products.FirstOrDefault(p => p.Id == id); // lấy ra xe muốn xóa
                qlbhContext.Products.Remove(car); //Xóa đi 
                qlbhContext.SaveChanges(); // lưu lại
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message); return false;
            }
        }
    }
}
