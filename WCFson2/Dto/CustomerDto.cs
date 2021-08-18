using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCFson2.Dto
{
    public class CustomerDto
    {
        public int IdCostumer { get; set; }
        public string UserName { get; set; }
        public int Password { get; set; }
        public string Mail { get; set; }
    }
}