using System;
using WeatherStation.Cross.Model.SensorData.Interfaces;

namespace WeatherStation.Cross.Model.SensorData
{
    public class SensorData: ISensorData
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public string UnitOfMeasure { get; set; }
        public string MeasureName { get; set; }
        public decimal Value { get; set; }
        public string Guid { get; set; }
        public DateTime TimeCreated { get; set; }
        public decimal? Latitude { get; set; }
        public decimal? Longitude { get; set; }
    }
}
