using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ccccc.A_DAL.Models;
using ccccc.A_DAL.repost;
namespace ccccc.servict
{
    internal class dangnhapservict
    {
     dangnhaprepost dangnhaprepost =new dangnhaprepost();   
        public string dangnhap1(string username,string password)
        {
            if (dangnhaprepost.checklogin(username,password))
            {
                return "dang nhap thanh cong";
            }
            else
            {
                return "dang nhap that bai";
            }
        }
        public string addacount(string username,string password)
        {
            Dangnhap a = new Dangnhap();
            a.Username = username;
            a.Password = password;
            return dangnhaprepost.addacount(a) ? "them thanh cong" : "them that bai";
        }

    }
}
