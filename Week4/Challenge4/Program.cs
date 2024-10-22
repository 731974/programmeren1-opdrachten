namespace Challenge4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }
        
        void Start()
        {
            TrafficLightSimulator trafficLightSimulator = new();
            TrafficLight trafficLight = new();

            TrafficLight light = TrafficLight.Red;
            trafficLightSimulator.SetLight(light);
            trafficLightSimulator.DisplayCurrentLight();

            light = TrafficLight.Yellow;
            trafficLightSimulator.SetLight(light);
            trafficLightSimulator.DisplayCurrentLight();

            light = TrafficLight.Green;
            trafficLightSimulator.SetLight(light);
            trafficLightSimulator.DisplayCurrentLight();

        }
    }
}
