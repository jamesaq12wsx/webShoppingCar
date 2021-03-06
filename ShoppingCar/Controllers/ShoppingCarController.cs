﻿using ShoppingCar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoppingCar.Controllers
{
    public class ShoppingCarController : Controller
    {
        // GET: ShoppingCar
        public ActionResult Index()
        {
            List<ProductViewModel> products = new List<ProductViewModel>();

            products.Add(new ProductViewModel
            {
                ProductName = "商品A",
                ProductGroup = "商品甲區",
                ProductPrice = 500,
                ProductAmt = 0,
                ProductBuy = false
            });
            products.Add(new ProductViewModel
            {
                ProductName = "商品B",
                ProductGroup = "商品甲區",
                ProductPrice = 500,
                ProductAmt = 0,
                ProductBuy = false
            });
            products.Add(new ProductViewModel
            {
                ProductName = "商品C",
                ProductGroup = "商品甲區",
                ProductPrice = 500,
                ProductAmt = 0,
                ProductBuy = false
            });
            products.Add(new ProductViewModel
            {
                ProductName = "商品D",
                ProductGroup = "商品甲區",
                ProductPrice = 500,
                ProductAmt = 0,
                ProductBuy = false
            });
            products.Add(new ProductViewModel
            {
                ProductName = "商品E",
                ProductGroup = "商品乙區",
                ProductPrice = 500,
                ProductAmt = 0,
                ProductBuy = false
            });
            products.Add(new ProductViewModel
            {
                ProductName = "商品F",
                ProductGroup = "商品乙區",
                ProductPrice = 500,
                ProductAmt = 0,
                ProductBuy = false
            });
            products.Add(new ProductViewModel
            {
                ProductName = "商品G",
                ProductGroup = "商品乙區",
                ProductPrice = 500,
                ProductAmt = 0,
                ProductBuy = false
            });
            products.Add(new ProductViewModel
            {
                ProductName = "商品H",
                ProductGroup = "商品乙區",
                ProductPrice = 500,
                ProductAmt = 0,
                ProductBuy = false
            });

            return View(products);
        }
    }
}