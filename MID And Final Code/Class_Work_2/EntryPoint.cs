using System;

namespace Class_Work_2
{
    class EmptyPoint
    {

        static void Main(string[] args)
        {
            Console.WriteLine("welcome to sensor program.");
            Console.WriteLine("Welcome to the pond monitoring system");
            Console.WriteLine("-------------------------------------");

            //SensorIO sio = new SensorIO();//constructor - method with same name as the class
            SensorIOArr sio = new SensorIOArr();
            sio.beginOperation();
        }
    }
}
