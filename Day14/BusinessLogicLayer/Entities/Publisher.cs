using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Entities
{
    public class Publisher:EntityBase
    {
        public string pub_id { set; get; }
        public string pub_name { set; get; }
        public string city { set; get; }
        public string state { set; get; }
        public string country { set; get; }
     
    }
}
