using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Product
    {
        public int prod_id { get; set; }
        public string prod_name { get; set; }
        public string prod_descript { get; set; }
        public string prod_price { get; set; }
        public string prod_pic { get; set; }
        public int cat_id { get; set; }
    }
}
