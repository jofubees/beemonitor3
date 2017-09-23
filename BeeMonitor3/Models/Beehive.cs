using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeeMonitor3.Models
{
    public class Beehive
    {
        public int BeehiveId { get; set; }
        public string BeehiveName { get; set; }
        public int ApiaryId { get; set; }

        public ICollection<BeehiveSensor> BeehiveSensors { get; set; }
        public Apiary Apiary { get; set; }
    }
}
