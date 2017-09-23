using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BeeMonitor3.Models
{
    public class Observation
    {
        public int ObservationId { get; set; }
        public DateTime ObsDateTime { get; set; }
        public float ObsValue { get; set; }
        [StringLength(50, MinimumLength = 3)]
        public string SensorName { get; set; }

        public Sensor Sensor { get; set; }
    }
}
