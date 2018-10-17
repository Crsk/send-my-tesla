using System;
using System.Collections.Generic;

namespace SendMyTesla.Models
{
    public partial class Parts
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? CarId { get; set; }
        public int? OptionId { get; set; }

        public Cars Car { get; set; }
        public Options Option { get; set; }
    }
}
