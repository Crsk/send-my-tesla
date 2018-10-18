using System;
using System.Collections.Generic;

namespace SendMyTesla.Models
{
    public partial class Dispatches
    {
        public Dispatches()
        {
            Orders = new HashSet<Orders>();
        }

        public int Id { get; set; }
        public int? ClientId { get; set; }
        public string DispatchAddress { get; set; }

        public Clients Client { get; set; }
        public ICollection<Orders> Orders { get; set; }
    }
}
