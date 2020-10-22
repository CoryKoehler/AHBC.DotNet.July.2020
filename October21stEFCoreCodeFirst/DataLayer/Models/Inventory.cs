using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace October21stEFCoreCodeFirst.DataLayer.Models
{
    public class Inventory
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public int StockLevelUsed { get; set; }
        public int StockLevelNew { get; set; }
    }
}
