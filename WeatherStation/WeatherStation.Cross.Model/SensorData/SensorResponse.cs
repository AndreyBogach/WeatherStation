using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation.Cross.Model.SensorData
{
    public class SensorResponse
    {
        public string Subject { get; set; }
        public string UnitOfMeasure { get; set; }
        public string MeasureName { get; set; }
        public decimal Value { get; set; }
        public string Guid { get; set; }
    }
}
