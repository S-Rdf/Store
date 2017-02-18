using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Models
{
    class ProductService
    {
        //-------------------------------------Constructor

        public ProductService()
        {
            Products_Count = 0;
        }

        //-------------------------------------Properties                
        public Product[] Products_Array { get; set; }

        public int Products_Count { get; set; }


        //-------------------------------------Methods

        public Product[] AddProduct(Product newProduct)
        {
            Products_Array[Products_Count - 1] = new Product()
            {
                EnglishName = newProduct.EnglishName,
                PersianName = newProduct.PersianName

            };
            Products_Count++;
            return Products_Array;
            
        }
    }
}
