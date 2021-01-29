using System;
using SmartFishFarm2.alldata;

namespace SmartFishFarm2.io
{
    /// <summary>
    /// This is the class to collect and display alll sensor data
    /// But this class will use an array of sensor struct
    /// </summary>
    class SensorIONoLogic : ParentSensorIOAbstract, ISensorIO//ParentSensorIO
    {
        //SmartPonds pond = null;
        SmartPonds pond = null;
        /// <summary>
        /// This method is for collecting temparature data from sensor.
        /// It does not need any parameters
        /// </summary>
        protected override void collectTempData()
        {
            //read first temp - but it may cause exception if non-numeric input is given
            //handle exception
            //ask the pond how many data it needs to collect - the array size pond has for sensor data
            int tempdata = pond.getTotalTempData();
            try
            {
                for (int i = 0; i < pond.getTotalTempData(); i++)
                {
                    Console.WriteLine("Please enter TEMP sensor id - ");
                    Sensor tempsensor;
                    tempsensor.sensor_id = Byte.Parse(Console.ReadLine());
                    //the following should be changed, we already know the
                    //type to be temp.  so we can set it ourselves, instead
                    //of accepting user input
                    //Console.WriteLine("Please enter sensor1 type - ");
                    tempsensor.sensor_type = sensortypes.TEMP;//Console.ReadLine();
                    Console.WriteLine("Please enter first date and time for data - ");
                    tempsensor.date_time = Console.ReadLine();
                    Console.WriteLine("Please enter sensor1 temp - ");
                    tempsensor.data_value = double.Parse(Console.ReadLine());//in future - try-catch
                    pond.saveSensorData(tempsensor);
                }
            }
            catch (Exception e)
            {
                //when wroking with large programs, you must write all the details of the 
                //exception in a log file
                //Console.WriteLine(e.StackTrace);//this line is too ugly for regular users, put it in log file
                Console.WriteLine(e.Message);
            }
        }

        protected override void collectPHData()
        {
            //read first temp - but it may cause exception if non-numeric input is given
            //handle exception
            try
            {
                //we ahve to begin in index 5 since the 0-4 are occupied
                //by temp data
                for (int i = 0; i < pond.getTotalPHData(); i++)
                {
                    Console.WriteLine("Please enter PH sensor id - ");
                    Sensor phsensor;
                    phsensor.sensor_id = Byte.Parse(Console.ReadLine());
                    //the following should be changed, we already know the
                    //type to be temp.  so we can set it ourselves, instead
                    //of accepting user input
                    //Console.WriteLine("Please enter sensor1 type - ");
                    phsensor.sensor_type = sensortypes.PH;//Console.ReadLine();
                    Console.WriteLine("Please enter first date and time for data - ");
                    phsensor.date_time = Console.ReadLine();
                    Console.WriteLine("Please enter sensor1 PH - ");
                    phsensor.data_value = double.Parse(Console.ReadLine());//in future - try-catch
                }
            }
            catch (Exception e)
            {
                //when wroking with large programs, you must write all the details of the 
                //exception in a log file
                //Console.WriteLine(e.StackTrace);//this line is too ugly for regular users, put it in log file
                Console.WriteLine(e.Message);
            }

        }
        public override void beginOperation()
        {
            base.beginOperation();
            pond = new SmartPonds(PondSize.SMALL);//need to define size of the pond.
            //call method to collect temparature data
            collectTempData();
            //call method to collect Ph data
            collectPHData();
            //now display the data

            ////now we have total of all temp and we can average
            Console.WriteLine("Average temp is " + pond.getTempAverage());

            //use for loop to print ph data and get average
            //but reset data_total first
            //data_total = 0.0;
            //for (??ki hobe tumi ber koro)
            //{

            //}
        }

        public void showError(string err)
        {
            Console.WriteLine("ERROR: " + err);
        }

        public void showMessage(string msg)
        {
            Console.WriteLine("------------------");
            Console.WriteLine(msg);
        }
    }
}
