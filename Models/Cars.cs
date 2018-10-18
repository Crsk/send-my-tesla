using System;
using System.Collections.Generic;

namespace SendMyTesla.Models
{
    public partial class Cars
    {
        public Cars()
        {
            Orders = new HashSet<Orders>();
        }

        public int Id { get; set; }
        public string Model { get; set; }
        public int? BasePrice { get; set; }
        public string Image { get; set; }
        public int Index { get; set; }

        public ICollection<Orders> Orders { get; set; }
    }
}
