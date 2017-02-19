using Shop.Service;
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
        public static Product[] Products_Array { get; set; }
        public static int Products_Count { get; set; }


        //-------------------------------------Methods

        public static void AddProduct(Product newProduct)
        {
            Products_Array[Products_Count++] = newProduct;
        }

  /*      public static Product[] DeleteProduct(int codeNo)
        {
            for (int i = 0; i < Products_Count; i++)
            {

            }
                return null;
        }
    */    

        public static Product ExpensiveProduct (Product[] productsArray)
        {            
            int i;
            int expensiveIndex = 0;
            long expensivePrice = -1;

            for (i=0; i< Products_Count; i++)
            {
                if (productsArray[i].Price >= expensivePrice )
                {
                    expensivePrice = productsArray[i].Price;
                    expensiveIndex = i;
                }
            }
            return productsArray[i];
        }
            }
}
