using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Authentication
    {
        public int auth_id { get; set; }
        public string uname { get; set; }
        public string passw { get; set; }
        public string cpassw { get; set; }
        public int actor_id { get; set; }
    }
}
