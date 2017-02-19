using System;


namespace Shop.Service
{
    public class Product
    {

        //-------------------------------------Constructors
        public Product(string englishName, string persianName, int count, long price)
        {
            this.EnglishName = englishName;
            this.PersianName = persianName;
            //this.ProduceDateTime = _produceDateTime;            
            this.Count = count;
            this.Price = price;

            _count = -1;
            _codeNO = -1;
            _completeExplain = "";            
            IsThere = false;
            _lastEditDate = DateTime.Now;
            _productDateTime = DateTime.Now;
            _price = -1;
            _producer = "";
            _shortExplain = "";

        }

        public Product(string englishName, string persianName)
        {
            this.EnglishName = englishName;
            this.PersianName = persianName;

            _count = -1;
            _codeNO = -1;
            _completeExplain = "";            
            IsThere = false;
            _lastEditDate = DateTime.Now;
            _productDateTime = DateTime.Now;
            _price = -1;
            _producer = "";
            _shortExplain = "";
        }

  /*      public Product()
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
*/
        //-------------------------------------Properties

        //public Buyer[] Buyer { get { } set {LastEditDate = DateTime.Now;} }


        private int _codeNO;
        public int CodeNO
        {
            get
            { return _codeNO; }
            set
            {
                _codeNO = value;
            }
        }


        private int _count;
        public int Count
        {
            get
            { return _count; }

            set
            {
                _count = value;
            }
        }

        private string _completeExplain;
        public string CompleteExplain
        {
            get
            { return _completeExplain; }

            set
            {
                _completeExplain = value;
            }
        }

        private string _englishName;
        public string EnglishName
        {
            get
            { return _englishName; }

            set
            {                
                _englishName = value;
            }
        }


        public bool IsThere { get; }


        private DateTime _lastEditDate;
        public DateTime LastEditDate
        {
            get
            { return _lastEditDate; }

            set
            {               
                _lastEditDate = value;
            }
        }

        private DateTime _productDateTime;
        public DateTime ProductDateTime
        {
            get
            { return _productDateTime; }

            set
            {
                _productDateTime = value;
            }
        }

        private long _price;
        public long Price
        {
            get
            { return _price; }

            set
            {
                _price = value;
            }
        }

        private string _persianName;
        public string PersianName
        {
            get
            { return _persianName; }

            set
            {
                _persianName = value;
            }
        }

        private string _producer; 
         public string Producer
        {
            get
            { return _producer; }

            set
            {
                _producer = value;
            }
        }

        private string _shortExplain;
        public string ShortExplain
        {
            get
            { return _shortExplain; }

            set
            {
                _shortExplain = value;
            }
        }

        private DateTime _produceDateTime;
        public DateTime ProduceDateTime
        {
            get
            { return _produceDateTime; }

            set
            {
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
