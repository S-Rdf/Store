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

            _count = -1;
            _codeNO = -1;
            _completeExplain = "";
            _englishName = "";
            IsThere = false;
            _lastEditDate = DateTime.Now;
            _productDateTime = DateTime.Now;
            _price = -1;
            _persianName = "";
            _producer = "";
            _shortExplain = "";

        }

        public Product(string _englishName, string _persianName)
        {
            this.EnglishName = _englishName;
            this.PersianName = _persianName;

            _count = -1;
            _codeNO = -1;
            _completeExplain = "";
            _englishName = "";
            IsThere = false;
            _lastEditDate = DateTime.Now;
            _productDateTime = DateTime.Now;
            _price = -1;
            _persianName = "";
            _producer = "";
            _shortExplain = "";
        }

        public Product()
        {
            _count = -1;
            _codeNO = -1;
            _completeExplain = "";
            _englishName = "";
            IsThere = false;
            _lastEditDate = DateTime.Now;
            _productDateTime = DateTime.Now;
            _price = -1;
            _persianName = "";
            _producer = "";
            _shortExplain = "";
        }

        //-------------------------------------Properties

        //public Buyer[] Buyer { get { } set {LastEditDate = DateTime.Now;} }


        int _codeNO;
        public int CodeNO
        {
            get
            { return _codeNO; }
            set
            {
                LastEditDate = DateTime.Now;
                _codeNO = value;
            }
        }


        int _count;
        public int Count
        {
            get
            { return _count; }

            set
            {
                LastEditDate = DateTime.Now;
                _count = value;
            }
        }

        string _completeExplain;
        public string CompleteExplain
        {
            get
            { return _completeExplain; }

            set
            {
                LastEditDate = DateTime.Now;
                _completeExplain = value;
            }
        }

        string _englishName;
        public string EnglishName
        {
            get
            { return _englishName; }

            set
            {
                LastEditDate = DateTime.Now;
                _englishName = value;
            }
        }


        public bool IsThere { get; }


        DateTime _lastEditDate;
        public DateTime LastEditDate
        {
            get
            { return _lastEditDate; }

            set
            {
                LastEditDate = DateTime.Now;
                _lastEditDate = value;
            }
        }

        DateTime _productDateTime;
        public DateTime ProductDateTime
        {
            get
            { return _productDateTime; }

            set
            {
                LastEditDate = DateTime.Now;
                _productDateTime = value;
            }
        }

        long _price;
        private long Price
        {
            get
            { return _price; }

            set
            {
                LastEditDate = DateTime.Now;
                _price = value;
            }
        }

        string _persianName;
        public string PersianName
        {
            get
            { return _persianName; }

            set
            {
                LastEditDate = DateTime.Now;
                _persianName = value;
            }
        }

        string _producer;
        public string Producer
        {
            get
            { return _producer; }

            set
            {
                LastEditDate = DateTime.Now;
                _producer = value;
            }
        }

        string _shortExplain;
        public string ShortExplain
        {
            get
            { return _shortExplain; }

            set
            {
                LastEditDate = DateTime.Now;
                _shortExplain = value;
            }
        }

        DateTime _produceDateTime;
        public DateTime ProduceDateTime
        {
            get
            { return _produceDateTime; }

            set
            {
                LastEditDate = DateTime.Now;
                _produceDateTime = value;
            }
        }


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
