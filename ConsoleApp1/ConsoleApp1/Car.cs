using System;

namespace ConsoleApp1
{
    public class Car
    {
        public string carBrand { get; set; }

        public string carNumber { get; set; }

        public void Drive()
        {

        }

        public void SlowDown()
        {

        }
        public void Stop()
        {

        }

        public void Beeping()
        {

        }
        public string GetGreeting()
        {
            string greeting = "Hello, you are driving in " + carBrand + " with number " + carNumber + ". Beep - Beep ";
            return greeting;
        }
    }
}
