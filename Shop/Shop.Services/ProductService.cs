﻿using Shop.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Service
{
    public static class ProductService
    {
        //-------------------------------------Constructor

        static ProductService()
        {
            Products_Array = new Product[100];
            Products_Count = 0;
        }

        //-------------------------------------Properties       
        private static Product[] Products_Array { get; set; }
        public static int Products_Count { get; set; }


        //-------------------------------------Methods

        public static void AddProduct(Product newProduct)
        {
            Products_Array[Products_Count++] = newProduct;
        }

 /*       public Product[] DeleteProduct(int codeNo)
        {
            return null;
        }
        */
    }
}