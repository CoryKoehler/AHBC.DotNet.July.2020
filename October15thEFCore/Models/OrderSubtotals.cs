using System;
using System.Collections.Generic;

namespace October15thEFCore.Models
{
    public partial class OrderSubtotals
    {
        public int OrderId { get; set; }
        public decimal? Subtotal { get; set; }
    }
}
