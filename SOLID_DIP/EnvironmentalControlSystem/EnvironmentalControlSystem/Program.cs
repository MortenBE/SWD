using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnvironmentalControlSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            //WindowActuatorSimulator myWindow = new WindowActuatorSimulator();
            //myWindow.closeWindow();
            //myWindow.openWindow();

            //TemperatureSensorSimulator mySensor = new TemperatureSensorSimulator();
            //while (true)
            //{
            //    mySensor.setTemp();
            //    Console.WriteLine(mySensor.getTemp());
            //}
            //Console.WriteLine("Hello World");

            ECS myEcs = new ECS();
            myEcs.regulateTemp();
        }
    }
}
