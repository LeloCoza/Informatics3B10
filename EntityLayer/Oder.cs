using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Oder
    {
        public int oder_id { get; set; }
        public string status { get; set; }
        public string tamount { get; set; }
        public DateTime date { get; set; }
        public int auth_id { get; set; }
    }
}
