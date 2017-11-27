using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MadShoppers.Models
{
    public class Itemclass
    {
        public int id { get; set; }
        public string name { get; set; }
        public byte image { get; set; }
        public float price { get; set; }
        public string description { get; set; }
    }
}