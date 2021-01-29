using System;
using System.Collections.Generic;
using System.Text;
using Class_Work_2.AllData;
namespace Class_Work_2
{

   /// <summary>
        /// This is the class to collect and display alll sensor data
        /// But this class will use an array of sensor struct
        /// </summary>
        class SensorIOArr
        {
            private const int TOTAL_SENSORS = 10;
            private const int TOTAL_TEMP_SENSORS = 5;
            private const int TOTAL_PH_SENSORS = 5;

            //create two structs for temp data and ph data
            //BUT WHAT IF WE HAVE A LOT SENSORS???  SHOULD USE AN ARRAY
            //Sensor tempsensor1, tempsensor2, phsensor1, phsensor2;
            Sensor[] sensor_data_arr = new Sensor[TOTAL_SENSORS];//5 temps and 5 phs
            /// <summary>
            /// This method is for collecting temparature data from sensor.
            /// It does not need any parameters
            /// </summary>
            private void collectTempData()
            {
                //read first temp - but it may cause exception if non-numeric input is given
                //handle exception
                try
                {
                    for (int i = 0; i < TOTAL_TEMP_SENSORS; i++)
                    {
                        Console.WriteLine("Please enter sensor id - ");
                        Sensor tempsensor;
                        tempsensor.sensor_id = Byte.Parse(Console.ReadLine());
                        //the following should be changed, we already know the
                        //type to be temp.  so we can set it ourselves, instead
                        //of accepting user input
                        //Console.WriteLine("Please enter sensor1 type - ");
                        tempsensor.sensor_type = "temp";//Console.ReadLine();
                        Console.WriteLine("Please enter first date and time for data - ");
                        tempsensor.date_time = Console.ReadLine();
                        Console.WriteLine("Please enter sensor{0} temp - ",i);
                        tempsensor.data_value = double.Parse(Console.ReadLine());//in future - try-catch
                        sensor_data_arr[i] = tempsensor;
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

            private void collectPHData()
            {
                //read first temp - but it may cause exception if non-numeric input is given
                //handle exception
                try
                {
                    //we ahve to begin in index 5 since the 0-4 are occupied
                    //by temp data
                    for (int i = 5; i < TOTAL_SENSORS; i++)
                    {
                        Console.WriteLine("Please enter sensor id - ");
                        Sensor phsensor;
                        phsensor.sensor_id = Byte.Parse(Console.ReadLine());
                        //the following should be changed, we already know the
                        //type to be temp.  so we can set it ourselves, instead
                        //of accepting user input
                        //Console.WriteLine("Please enter sensor1 type - ");
                        phsensor.sensor_type = "ph";//Console.ReadLine();
                        Console.WriteLine("Please enter first date and time for data - ");
                        phsensor.date_time = Console.ReadLine();
                        Console.WriteLine("Please enter sensor {0} ph - ",i);
                        phsensor.data_value = double.Parse(Console.ReadLine());//in future - try-catch
                        sensor_data_arr[i] = phsensor;
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
            public void beginOperation()
            {
                //call method to collect temparature data
                collectTempData();
                //call method to collect Ph data
                collectPHData();
                //now display the data
                //use for loop to print temp data and get temp average
                //please do remember - temp data may not be sequential
                double data_total = 0.0;
                for (int i = 0; i < TOTAL_SENSORS; i++)
                {
                    //use for loop to print temp data
                    if (sensor_data_arr[i].sensor_type == "temp")
                    {
                        Console.WriteLine("Temp data-> id:" + sensor_data_arr[i].sensor_id + "-" + sensor_data_arr[i].sensor_type
                                        + " Date & time=" + sensor_data_arr[i].date_time + " Temp=" + sensor_data_arr[i].data_value);
                        data_total += sensor_data_arr[i].data_value;
                    }
                }
                //now we have total of all temp and we can average
                Console.WriteLine("Average temp is " + (data_total / TOTAL_TEMP_SENSORS));

                //use for loop to print ph data and get average
                //but reset data_total first
                data_total = 0.0;
                for (int i=5;i<TOTAL_SENSORS;i++)
                {
                   if(sensor_data_arr[i].sensor_type=="ph")
                   {
                    Console.WriteLine("Ph data-> id:" + sensor_data_arr[i].sensor_id + "-" + sensor_data_arr[i].sensor_type
                                    + " Date & time=" + sensor_data_arr[i].date_time + " Ph=" + sensor_data_arr[i].data_value);
                    data_total += sensor_data_arr[i].data_value;
                    }
                }
                  //now we have total of all temp and we can average
                 Console.WriteLine("Average ph is " + (data_total / TOTAL_PH_SENSORS));
        }
        }
}

