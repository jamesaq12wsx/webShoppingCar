using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebShoppingCar.Models
{
    public class ShoppingCarViewModel
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Buyer name could not be null")]
        [DisplayName("購買者姓名")]
        public string BuyerName { get; set; }

        //[System.Web.Mvc.Remote("DateValid", "StringValid", ErrorMessage = "日期必須在訂購日三天以後")]
        [DisplayName("送貨時間")]
        public DateTime DeliverDate { get; set; }

        [Required]
        public List<ProductViewModel> pList;
    }
}