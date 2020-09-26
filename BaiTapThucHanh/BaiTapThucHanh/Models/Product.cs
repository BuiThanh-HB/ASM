using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Web;

namespace BaiTapThucHanh.Models
{
    public class Product
    {
        public int id { get; set; }
        public string name { get; set; }
        public long price { get; set; }
        public string image { get; set; }
    }
}