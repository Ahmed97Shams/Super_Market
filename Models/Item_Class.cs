using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SUPER_MARKET.Models
{
    public class Item_Class
    {
        public int Id { get; set; }
        public string ItemName { get; set; }
        public decimal ItemPrice { get; set; }
        public decimal ItemQuantity { get; set; }
        public Groups_class Groups { get; set; }
    }
}
