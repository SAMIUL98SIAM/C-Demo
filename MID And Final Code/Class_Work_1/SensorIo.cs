using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Work_1
{

    /// <summary>
    /// This is the class to collect and display alll sensor data
    /// </summary>
    class SensorIO
        {
            // Define temp data
            byte sensor_id_temp = 12;
            string sensor_type_temp ="celcious";
            string date_time_temp1 = "2020~10~10~10AM";
            double temp1 = 23.67;
            string date_time_temp2 = "2020~10~10~5PM";
            double temp2 = 21.00;
            // Now ph sensor info
            byte sensor_id_ph = 12;
            string sensor_type_ph = "ph";
            string date_time_ph1 = "2020~10~10~10AM";
            double ph1 = 5.4;
            string date_time_ph2 = "2020~10~10~10AM";
            double ph2 = 3.00;
            /// <summary>
            /// This method is for collecting temperature  data for sensor
            /// This doesn't need any parameter
            /// </summary>
            private void collectTempData() { 
                //make thos more flexible by taking data from user
                //now you will learn type conversion
                //input the first data for temp 
                try
                {
                    Console.WriteLine("Plase enter the first date and time for data - ");
                    date_time_temp1 = Console.ReadLine();
                    //read first temp - but it may cause exception if non-numaric input is given
                    //hadle exception
                    Console.WriteLine("Plase enter the first temp - ");
                    temp1 = double.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    //when working with large programme , you must all the details of the
                    //exception in a log file
                    // Console.WriteLine(e.StackTrace); this line is too ugly for regular user
                    Console.WriteLine(e.Message);

                }
                //input the second data for ph       
                try
                {
                    Console.WriteLine("Plase enter the second date and time for data - ");
                    date_time_temp2 = Console.ReadLine();
                    //read second temp - but it may cause exception if non-numaric input is given
                    //hadle exception
                    Console.WriteLine("Plase enter the second temp - ");
                    temp2 = double.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    //when working with large programme , you must all the details of the
                    //exception in a log file
                    // Console.WriteLine(e.StackTrace); this line is too ugly for regular user
                    Console.WriteLine(e.Message);
                }
            }
            /// <summary>
            /// This method is for collecting ph  data for sensor
            /// This doesn't need any parameter 
            /// </summary>
            private void collectPhData()
            {

                //input the first data for ph
                try
                {
                    Console.WriteLine("Plase enter the first date and time for data - ");
                    date_time_ph1 = Console.ReadLine();
                    //read first ph - but it may cause exception if non-numaric input is given
                    //hadle exception
                    Console.WriteLine("Plase enter the first ph - ");
                    ph1 = double.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    //when working with large programme , you must all the details of the
                    //exception in a log file
                    // Console.WriteLine(e.StackTrace); this line is too ugly for regular user
                    Console.WriteLine(e.Message);

                }
                //input the second data for temp       
                try
                {
                    Console.WriteLine("Plase enter the second date and time for data - ");
                    date_time_ph2 = Console.ReadLine();
                    //read second ph - but it may cause exception if non-numaric input is given
                    //hadle exception
                    Console.WriteLine("Plase enter the second ph - ");
                    ph2 = double.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    //when working with large programme , you must all the details of the
                    //exception in a log file
                    // Console.WriteLine(e.StackTrace); this line is too ugly for regular user
                    Console.WriteLine(e.Message);
                }
            }
            public void beginOperartion()
            {

                //call method to collect temp data
                collectTempData();
                //call method to collect ph data
                collectPhData();
                //Now define data we need
                //----------------------------------------------------------------
                //Now display data
                Console.WriteLine("Temp data 1 = " + sensor_id_temp + " - " + sensor_type_temp + " Date and time " + date_time_temp1 + " Temp = " + temp1);
                Console.WriteLine("Temp data 2 = " + sensor_id_temp + " - " + sensor_type_temp + " Date and time " + date_time_temp2 + " Temp = " + temp2);
                Console.WriteLine("Ph data 1 = " + sensor_id_ph + " - " + sensor_type_ph + " Date and time " + date_time_ph1 + " Ph = " + ph1);
                Console.WriteLine("ph data 2 = " + sensor_id_ph + " - " + sensor_type_ph + " Date and time " + date_time_ph2 + " Ph = " + ph2);

            }
        } 
}
