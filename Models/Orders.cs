using System;
using System.Collections.Generic;

namespace SendMyTesla.Models
{
    public partial class Orders
    {
        public Orders()
        {
            Parts = new HashSet<Parts>();
        }

        public int Id { get; set; }
        public int? CarId { get; set; }
        public int? DispatchId { get; set; }
        public DateTime? Date { get; set; }

        public Cars Car { get; set; }
        public Dispatches Dispatch { get; set; }
        public ICollection<Parts> Parts { get; set; }
    }
}
