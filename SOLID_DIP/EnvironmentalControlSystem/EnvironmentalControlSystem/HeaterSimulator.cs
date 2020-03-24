using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnvironmentalControlSystem
{
    class HeaterSimulator
    {
        private bool _isOn;

        public HeaterSimulator()
        {
            _isOn = false;
        }
        public void turnOnHeat()
        {
            if (_isOn == false)
            {
                Console.WriteLine("Heat is turned on");
                _isOn = true;
            }
        }

        public void turnOffHeat()
        {
            if (_isOn == true)
            {
                Console.WriteLine("Heat is turned off");
                _isOn = false;
            }
        }
    }
}
