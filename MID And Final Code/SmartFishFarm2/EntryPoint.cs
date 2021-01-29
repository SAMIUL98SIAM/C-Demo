using System;

namespace SmartFishFarm2.io
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            //SensorIO sio = new SensorIO();//constructor - method with same name as the class
            //SensorIOArr sio = new SensorIOArr();
            //having an abstract class as parent is beneficial since I can use this class to 
            //create any child object without using that child object's class in variable (sio) declaration
            ParentSensorIOAbstract sio = null;
            Console.WriteLine("Please enter the type of IO class you want to use:");
            String whatioclass = Console.ReadLine();
            if (whatioclass.Equals("NOARR"))
            {
                sio = new SensorIO();
            }
            else if (whatioclass.Equals("ARR"))
            {
                sio = new SensorIOArr();
            }
            else if (whatioclass.Equals("SIMPLE"))
            {
                sio = new SensorIONoLogic();
            }
            else if (whatioclass.Equals("FILE"))
            {
                sio = new SensorIOFiles();
            }
            else
            {
                Console.WriteLine("Cannot create the IO class you wanted.");
                return;
            }
            //
            sio.beginOperation();
        }
    }
}
