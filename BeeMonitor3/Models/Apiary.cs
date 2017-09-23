using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeeMonitor3.Models
{
    public class Apiary
    {
        public int ApiaryId { get; set; }
        public string ApiaryName { get; set; }
        public string Postcode { get; set; }

        public ICollection<Beehive> Beehives { get; set; }

    }
}
