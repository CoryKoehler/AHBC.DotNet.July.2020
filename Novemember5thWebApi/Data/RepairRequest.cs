using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Novemember5thWebApi.Data
{
    public class RepairRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CustomerName { get; set; }
        public string CarType { get; set; }
        public int PartId { get; set; }
        public Part Part {get; set;}
    }
}
