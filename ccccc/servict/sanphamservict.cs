using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ccccc.A_DAL.repost;
using ccccc.A_DAL.Models;
namespace ccccc.servict
{
    internal class sanphamservict
    {
        sanphamrepost sanphamrepost = new sanphamrepost();
       
        public List<Product> showall()
        {
            return sanphamrepost.GetProducts().ToList();
        }
        public string CreateNewsp(string masp, string name, int price, int amount)
        {
            Product c = new Product();
            c.MaSp = masp;
            c.ProductName = name;
            c.Price = price;
            c.Amount = amount;
            return sanphamrepost.Addsanpham(c) ? "Thêm thành công" : "Thêm thất bại";
        }
        public string DeleteAsp(int id)
        {
            return sanphamrepost.deletesp(id) ? "Xóa thành công" : "Xóa thất bại";
        }
    }
}
