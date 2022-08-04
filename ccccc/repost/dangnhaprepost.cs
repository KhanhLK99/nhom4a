using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ccccc.A_DAL.Models;
namespace ccccc.A_DAL.repost
{
    internal class dangnhaprepost
    {
        qlbh1Context qlbhContext = new qlbh1Context();
        public bool checklogin(string username ,string password)
        {
            var dn = qlbhContext.Dangnhaps.Where(p => p.Username == username && p.Password == password);
            return dn != null;
        }

        public bool addacount(Dangnhap a)
        {
            try
            {
                qlbhContext.Dangnhaps.Add(a);
                return true;
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
                return false;
            }
        }
    }
}
