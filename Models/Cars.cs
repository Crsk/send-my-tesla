using System;
using System.Collections.Generic;

namespace SendMyTesla.Models
{
    public partial class Cars
    {
        public Cars()
        {
            Orders = new HashSet<Orders>();
            Parts = new HashSet<Parts>();
        }

        public int Id { get; set; }
        public string Model { get; set; }
        public int? BasePrice { get; set; }

        public ICollection<Orders> Orders { get; set; }
        public ICollection<Parts> Parts { get; set; }
    }
}
