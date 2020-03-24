using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnvironmentalControlSystem
{
    class WindowActuatorSimulator
    {

        private bool _isOpen;

        public WindowActuatorSimulator()
        {
            _isOpen = false;
        }
        public void openWindow()
        {
            if (_isOpen == false)
            {
                Console.WriteLine("Window is open");
                _isOpen = true;
            }
        }

        public void closeWindow()
        {
            if (_isOpen == true)
            {
                Console.WriteLine("Window is closed");
                _isOpen = false;
            }
        }
    }
}
