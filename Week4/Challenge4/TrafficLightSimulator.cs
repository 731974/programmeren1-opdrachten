using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge4
{
    public class TrafficLightSimulator
    {

        TrafficLight trafficLight;

       public TrafficLightSimulator()
        {
            trafficLight = TrafficLight.Red;
        }

        public void SetLight(TrafficLight light)
        {
            Console.WriteLine($"Changing light to {light}");
            trafficLight = light;
        }

        public void DisplayCurrentLight()
        {

            Console.WriteLine($"Current traffic ligt: {trafficLight}");

        }

    }
}
