using System;
using System.Collections.Generic;

namespace ccccc.A_DAL.Models
{
    public partial class Product
    {
        public int Id { get; set; }
        public string MaSp { get; set; } = null!;
        public string ProductName { get; set; } = null!;
        public int Price { get; set; }
        public int Amount { get; set; }
    }
}
