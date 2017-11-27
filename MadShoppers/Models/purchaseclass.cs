using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MadShoppers.Models
{
    public class purchaseclass
    {
        public int  id { get; set; }
        public Itemclass item { get; set; }
        public int itemid { get; set; }
        public Customerclass customer { get; set; }
        public int customerid { get; set; }
    }
}