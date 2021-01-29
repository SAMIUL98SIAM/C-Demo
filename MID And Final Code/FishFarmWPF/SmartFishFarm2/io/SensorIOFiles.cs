using System;
using System.Collections.Generic;
using System.Text;
using SmartFishFarm2.alldata;
namespace SmartFishFarm2.io
{
    class SensorIOFiles:ParentSensorIOAbstract,ISensorIO
    {
       
        SmartPondsWithFiles smartPondsWithFiles = null;
        /// <summary>
        /// This method is for collecting temparature data from sensor.
        /// It does not need any parameters
        /// </summary>
        protected override void collectTempData()
        {
            //   int tempData = smartPonds.getTotalTempData();
            //read first temp - but it may cause exception if non-numeric input is given
            //handle exception
            try
            {
                for (int i = 0; i < smartPondsWithFiles.getTotalTempData(); i++)

                {
                    Console.WriteLine("Please enter TEMP sensor {0} id - ", i);
                    Sensor tempsensor;
                    tempsensor.sensor_id = Byte.Parse(Console.ReadLine());
                    //the following should be changed, we already know the
                    //type to be temp.  so we can set it ourselves, instead
                    //of accepting user input
                    //Console.WriteLine("Please enter sensor1 type - ");
                    tempsensor.sensor_type = sensortypes.TEMP;//Console.ReadLine();
                    Console.WriteLine("Please enter first date and time for data - ");
                    tempsensor.date_time = Console.ReadLine();
                    Console.WriteLine("Please enter sensor {0} temp - ", i);
                    tempsensor.data_value = double.Parse(Console.ReadLine());//in future - try-catch
                    smartPondsWithFiles.saveSensorData(tempsensor);
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
                for (int i = smartPondsWithFiles.getTotalTempData(); i < smartPondsWithFiles.getTotalData(); i++)
                {
                    Console.WriteLine("Please enter PH sensor {0} id - ", i);
                    Sensor phsensor;
                    phsensor.sensor_id = Byte.Parse(Console.ReadLine());
                    //the following should be changed, we already know the
                    //type to be temp.  so we can set it ourselves, instead
                    //of accepting user input
                    //Console.WriteLine("Please enter sensor1 type - ");
                    phsensor.sensor_type = sensortypes.PH;//Console.ReadLine();
                    Console.WriteLine("Please enter first date and time for data - ");
                    phsensor.date_time = Console.ReadLine();
                    Console.WriteLine("Please enter sensor {0} PH - ", i);
                    phsensor.data_value = double.Parse(Console.ReadLine());//in future - try-catch
                    smartPondsWithFiles.saveSensorData(phsensor);
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
            smartPondsWithFiles = new SmartPondsWithFiles(PondSize.SMALL,this);
            collectTempData();
           //collectPHData();
            Console.WriteLine("Average Temp is " + smartPondsWithFiles.getTempAverage());
            //Console.WriteLine("Average Ph is " + smartPonds.getPhAverage());
           
        }
        public void showError(string error)
        {
            Console.WriteLine("Error: " + error);
        }
        public void showMssg(string msg)
        {
            Console.WriteLine("---------------");
            Console.WriteLine(msg);

        }

       
    }
}
