using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class SellHistory
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public Nullable<int> Quantity { get; set; }
        public Nullable<int> Price { get; set; }
        public Nullable<int> User_Id { get; set; }
        public string Date { get; set; }
    }
}
