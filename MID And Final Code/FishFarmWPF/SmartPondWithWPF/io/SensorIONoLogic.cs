using System;
using SmartFishFarm2.alldata;

namespace SmartFishFarm2.io
{
    /// <summary>
    /// This is the class to collect and display alll sensor data
    /// But this class will use an array of sensor struct
    /// </summary>
    class SensorIONoLogic : ParentSensorIOAbstract 
    {    
        SmartPonds smartPonds = null;
        //SmartPondsWithFiles smartPonds = null;
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
                for (int i = 0; i < smartPonds.getTotalTempData(); i++)

                {
                    Console.WriteLine("Please enter TEMP sensor {0} id - ",i);
                    Sensor tempsensor;
                    tempsensor.sensor_id = Byte.Parse(Console.ReadLine());
                    //the following should be changed, we already know the
                    //type to be temp.  so we can set it ourselves, instead
                    //of accepting user input
                    //Console.WriteLine("Please enter sensor1 type - ");
                    tempsensor.sensor_type = sensortypes.TEMP;//Console.ReadLine();
                    Console.WriteLine("Please enter first date and time for data - ");
                    tempsensor.date_time = Console.ReadLine();
                    Console.WriteLine("Please enter sensor {0} temp - ",i);
                    tempsensor.data_value = double.Parse(Console.ReadLine());//in future - try-catch
                    smartPonds.saveSensorData(tempsensor);
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
                for (int i = smartPonds.getTotalTempData(); i <smartPonds.getTotalData(); i++)
                {
                    Console.WriteLine("Please enter PH sensor {0} id - ",i);
                    Sensor phsensor;
                    phsensor.sensor_id = Byte.Parse(Console.ReadLine());
                    //the following should be changed, we already know the
                    //type to be temp.  so we can set it ourselves, instead
                    //of accepting user input
                    //Console.WriteLine("Please enter sensor1 type - ");
                    phsensor.sensor_type = sensortypes.PH;//Console.ReadLine();
                    Console.WriteLine("Please enter first date and time for data - ");
                    phsensor.date_time = Console.ReadLine();
                    Console.WriteLine("Please enter sensor {0} PH - ",i);
                    phsensor.data_value = double.Parse(Console.ReadLine());//in future - try-catch
                    smartPonds.saveSensorData(phsensor);
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
            smartPonds = new SmartPonds(PondSize.SMALL);
            collectTempData();
            collectPHData(); 
            Console.WriteLine("Average Temp is " + smartPonds.getTempAverage());
           // Console.WriteLine("Average Ph is " + smartPonds.getPhAverage());
            ////call method to collect temparature data
            //collectTempData();
            ////call method to collect Ph data
            //collectPHData();
            ////now display the data
            ////use for loop to print temp data and get temp average
            ////please do remember - temp data may not be sequential
            //double data_total_temp = 0.0,data_total_ph = 0.0;
            //for (int i = 0; i < TOTAL_SENSORS; i++)
            //{
            //    //use for loop to print temp data
            //    if (sensor_data_arr[i].sensor_type == sensortypes.TEMP)
            //    {
            //        Console.WriteLine("Temp data-> id:" + sensor_data_arr[i].sensor_id + "-" + sensor_data_arr[i].sensor_type
            //                        + " Date & time=" + sensor_data_arr[i].date_time + " Temp=" + sensor_data_arr[i].data_value);
            //        data_total_temp += sensor_data_arr[i].data_value;
            //    }


            //}
            ////now we have total of all temp and we can average
            //Console.WriteLine("Average temp is " + (data_total_temp / TOTAL_TEMP_SENSORS));

            //for (int i = 0; i < TOTAL_PH_SENSORS; i++)
            //{
            //    if (sensor_data_arr[i].sensor_type == sensortypes.PH)
            //    {
            //        Console.WriteLine("Ph data-> id:" + sensor_data_arr[i].sensor_id + "-" + sensor_data_arr[i].sensor_type
            //                  + " Date & time=" + sensor_data_arr[i].date_time + " Ph=" + sensor_data_arr[i].data_value);
            //        data_total_ph += sensor_data_arr[i].data_value;
            //    }
            //}
            ////now we have total of all temp and we can average
            //Console.WriteLine("Average ph is " + (data_total_ph / TOTAL_PH_SENSORS));
        }
    }
}
