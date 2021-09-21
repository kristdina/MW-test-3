using System;

namespace ConsoleApp1
{
    public class Phone
    {
        public string Name { get; set; }
        
        public string Brand { get; set; }

        public string Model { get; set; }

        private int _size; 
        public int Size 
        { 
            get
            {
                return _size;
            }
            set 
            {
                _size = Math.Abs(value);
            } 
        }

        public void Call()
        { 
        
        }

        public void Sms()
        {

        }
        public string GetGreeting()
        {
            string greeting = "Hello, " + Name + ", you have " + Brand + " " + Model + " phone. And yours phone size is " + Size + ". You can make a calls and sent sms with your phone.";
            
            return greeting;
        }
    }
}
