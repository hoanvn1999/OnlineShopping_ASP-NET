using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineShopping.Models
{
    [Serializable]
    public class Cart
    {
        public int ProductID { set; get; }
        public string PruductIMG { set; get; }
        public string ProductName { set; get; }
        public double ProductPrice { set; get; }
        public int Quantity { set; get; }
    }
}