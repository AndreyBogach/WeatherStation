using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherStation.Cross.Model.SensorData;
using WeatherStation.Service.SensorService.Interfaces;

namespace WeatherStation.Service.SensorService
{
    public class SensorService : ISensorService
    {
        public void AddData(SensorResponse response)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SensorData> GetData(string guid)
        {
            throw new NotImplementedException();
        }
    }
}
