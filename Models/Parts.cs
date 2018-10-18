using System;
using System.Collections.Generic;

namespace SendMyTesla.Models
{
    public partial class Parts
    {
        public int Id { get; set; }
        public int? OrderId { get; set; }
        public int? OptionId { get; set; }

        public Options Option { get; set; }
        public Orders Order { get; set; }
    }
}
