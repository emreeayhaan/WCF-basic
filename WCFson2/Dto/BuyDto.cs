using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCFson2.Dto
{ 
    public class BuyDto
    {
        public int BHid { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }
        public int CustomerId { get; set; }
        public int ProductId { get; set; }
    }
}