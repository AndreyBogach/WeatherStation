using System;

namespace WeatherStation.Cross.Model.SensorData.Interfaces
{
    public interface ISensorData
    {
        int Id { get; }
        string Subject { get; }
        string UnitOfMeasure { get; }
        string MeasureName { get; }
        decimal Value { get; }
        string Guid { get; }
        DateTime TimeCreated { get; }
        decimal? Latitude { get; }
        decimal? Longitude { get; }
    }
}
