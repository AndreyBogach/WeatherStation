using System.Collections.Generic;
using WeatherStation.Cross.Model.SensorData;

namespace WeatherStation.Service.SensorService.Interfaces
{
    public interface ISensorService
    {
        void AddData(SensorResponse response);

        IEnumerable<SensorData> GetData(string guid);
    }
}
