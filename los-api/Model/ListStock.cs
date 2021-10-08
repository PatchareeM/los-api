using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace los_api.Model
{
    public class ListStock
    {
        public int id { get; set; }
        public int productId { get; set; }
        public int amount { get; set; }

        public string name { get; set; }
    }
}
