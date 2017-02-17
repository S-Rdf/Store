using System;


namespace Shop.Models
{
    public class Product
    {

//-------------------------------------Constructors
        public Product(string _englishName, string _persianName, int _count, long _price)
        {
            this.EnglishName = _englishName;
            this.PersianName = _persianName;
            //this.ProduceDateTime = _produceDateTime;            
            this.Count = _count;
            this.Price = _price;
            
        }

        public Product(string _englishName, string _persianName)
        {
            this.EnglishName = _englishName;
            this.PersianName = _persianName;
            this.Count = 0;
        }

//-------------------------------------Properties

        public Buyer[] Buyer { get; set; }

        public int CodeNO { get; set; }

        public int Count { get; set; }
        //public int Count { get; private set; }

        public string CompleteExplain { get; set; }

        public string EnglishName { get; set; }

        public bool IsThere { get; }

        public DateTime LastEditDate { get; set; }

        public DateTime ProduceDateTime { get; set; }

        private long Price { get; set; }        

        public string PersianName { get; set; }               

        public string Producer { get; set; }

        public string ShortExplain { get; set; }
        

        //-------------------------------------METHODS

        public void AddCount(int _count)
        {
            Count += _count;
        }

        public void ChangePrice(long newPrice)
        {
            Price = newPrice;         
        }

        ~Product() { }
    }
}
