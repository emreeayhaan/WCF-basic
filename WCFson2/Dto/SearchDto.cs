using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCFson2.Dto
{
    //Kullanıcının bilgilerini(SkipCount,Datetime,Size ve From )görüntülemek ve kullanmak için oluşturduğumuz DTO class'ı.
    class SearchDto
    {
        public int SkipCount { get; set; }
        public DateTime DateTime { get; set; }
        public string Size { get; set; }
        public object From { get; set; }

    }
}