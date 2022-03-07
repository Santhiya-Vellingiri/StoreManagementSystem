using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagementSystem
{
   public class ProductDetails
    {
        public string Image { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public string Category { get; set; }
        public long Code { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public int AlertQuantity { get; set; }
    }
}
