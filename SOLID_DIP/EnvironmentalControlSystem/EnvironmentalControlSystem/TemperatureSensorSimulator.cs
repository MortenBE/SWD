using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnvironmentalControlSystem
{
    class TemperatureSensorSimulator
    {
        private int _randomTemp;

        public TemperatureSensorSimulator()
        {
            _randomTemp = 5;
        }

        public void setTemp()
        {
            Random randomTemp = new Random();
            if (_randomTemp >= 1 && _randomTemp < 10)
            {
                _randomTemp += randomTemp.Next(-1, 2); //
            }

        }
        public int getTemp()
        {
            return _randomTemp;
        }
    }
}
