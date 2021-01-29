using System;

namespace Class_Work_1
{
    class EmptyPoint
    {
       public static void Main(String[] arg)
       {
            Console.WriteLine("-------------Welcome dear smart farmer--------------");
            Console.WriteLine("---------Welcome to pond monitoring System----------");
            Console.WriteLine("----------------------------------------------------");
            SensorIO sensorIO = new SensorIO();
            sensorIO.beginOperartion();


        }
    }
}
