using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Models
{
    class Product
    {
        public int CodeNO { get; set; }

        public string PersianName { get; set; }

        public string EnglishName { get; set; }

        public int Conunt { get; set; }

        public bool IsThere { get; }

        public string Producer { get; set; }

        public string CompleteExplain { get; set; }

        public string ShortExplain { get; set; }

        public long Cost { get; set; }

        public ProductBuyer[] Buyers { get; set; }

        public DateTime ProduceDate { get; set; }

        public DateTime LastEditDate { get; set; }
    }
}
