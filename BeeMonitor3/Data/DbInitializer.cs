using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BeeMonitor3.Models;


namespace BeeMonitor3.Data
{
    public class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.SensorTypes.Any())
            {
                return;   // DB has been seeded
            }

            var sensorTypes = new SensorType[]
            {
            new SensorType {TypeDescription="Hive Temperature"},
            new SensorType {TypeDescription="Hive Mass"},
            new SensorType {TypeDescription="Battery Level"},
            new SensorType {TypeDescription="Ambient Temperature"}
            };
            foreach (SensorType s in sensorTypes)
            {
                context.SensorTypes.Add(s);
            }
            context.SaveChanges();

            var apiaries = new Apiary[]
            {
            new Apiary {ApiaryName="Test Apiary",Postcode="KT1"}
            };
            foreach (Apiary c in apiaries)
            {
                context.Apiaries.Add(c);
            }
            context.SaveChanges();
        }
    }
}
