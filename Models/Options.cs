using System;
using System.Collections.Generic;

namespace SendMyTesla.Models
{
    public partial class Options
    {
        public Options()
        {
            Parts = new HashSet<Parts>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }

        public ICollection<Parts> Parts { get; set; }
    }
}
