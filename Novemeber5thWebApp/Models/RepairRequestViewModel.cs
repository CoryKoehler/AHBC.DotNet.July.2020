using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Novemeber5thWebApp.Models
{
    public class RepairRequestViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CustomerName { get; set; }
        public string CarType { get; set; }
        public int PartId { get; set; }
        
        //Part information
        //public PartViewModel Part { get; set; }
    }
}
