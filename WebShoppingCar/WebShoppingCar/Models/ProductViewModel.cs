using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace WebShoppingCar.Models
{
    public class ProductViewModel
    {
        [DisplayName("商品")]
        public string ProductName { get; set; }

        [DisplayName("價錢")]
        public int ProductPrice { get; set; }

        [DisplayName("數量")]
        public int ProductAmt { get; set; }

        [DisplayName("商品區")]
        public string ProductGroup { get; set; }

        [DisplayName("是否購買")]
        public bool ProductBuy { get; set; }
    }
}