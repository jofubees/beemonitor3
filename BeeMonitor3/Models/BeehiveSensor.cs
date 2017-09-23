﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace BeeMonitor3.Models
{
    public class BeehiveSensor
    {
        public int BeehiveId { get; set; }
        [StringLength(50, MinimumLength = 3)]
        public string SensorName { get; set; }

        public Beehive Beehive { get; set; }
        public Sensor Sensor { get; set; }
    }
}
