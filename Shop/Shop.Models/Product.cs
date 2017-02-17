using System;


namespace Shop.Models
{
    public class Product
    {
        private string _enlishName;

        private string _persianName;

        private DateTime _dateTime;

        public Product(string _englishName, string _persianName, int _count, long _price)
        {
            this.EnglishName = _englishName;
            this.PersianName = _persianName;
            //this.ProduceDateTime = _produceDateTime;
            this.Conunt = _count;
            this.Price = _price;
        }

        public Product(string _englishName, string _persianName)
        {
            this.EnglishName = _englishName;
            this.PersianName = _persianName;
        }

        public int CodeNO { get; set; }

        public string PersianName { get; set; }

        public string EnglishName { get; set; }

        public int Conunt { get; set; }

        public bool IsThere { get; }

        public string Producer { get; set; }

        public string CompleteExplain { get; set; }

        public string ShortExplain { get; set; }

        public long Price{ get; set; }

        public Buyer[] Buyer { get; set; }

        public DateTime ProduceDateTime { get; set; }

        public DateTime LastEditDate { get; set; }
    }
}
