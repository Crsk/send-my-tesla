using System;
using System.Collections.Generic;

namespace SendMyTesla.Models
{
    public partial class Clients
    {
        public Clients()
        {
            Dispatches = new HashSet<Dispatches>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public ICollection<Dispatches> Dispatches { get; set; }
    }
}
