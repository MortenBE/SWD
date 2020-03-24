using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace EnvironmentalControlSystem
{
    class ECS
    {
        private HeaterSimulator _myHeater;
        private TemperatureSensorSimulator _mySensor;
        private WindowActuatorSimulator _myWindow;

        public int _maxTemp;
        public int _minTemp;

       
        public ECS()
        {
            _maxTemp = 6;
            _minTemp = 4;
            _myHeater = new HeaterSimulator();
            _mySensor = new TemperatureSensorSimulator();
            _myWindow = new WindowActuatorSimulator();
        }
        public void regulateTemp()
        {
            while (true)
            {
                
                _mySensor.setTemp();
                int temp = _mySensor.getTemp();

                Console.WriteLine("Temp {0}", temp);

                if (temp > _maxTemp)
                {
                    _myHeater.turnOffHeat();
                    _myWindow.openWindow();

                }
                else if (_mySensor.getTemp() < _minTemp)
                {
                    _myHeater.turnOnHeat();
                    _myWindow.closeWindow();
                }
                else
                {
                    _myHeater.turnOffHeat();
                    _myWindow.closeWindow();
                }
                Thread.Sleep(1000);

            }
        }
    }
}
