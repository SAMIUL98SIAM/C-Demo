using System;

namespace SmartFishFarm1
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to sensor program.");
            Console.WriteLine("Welcome to the pond monitoring system");
            Console.WriteLine("-------------------------------------");

            SensorIO sio = new SensorIO();//constructor - method with same name as the class
            sio.beginOperation();
        }
    }
}
