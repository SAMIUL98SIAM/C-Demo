using System;
using System.Collections.Generic;
using System.Text;

namespace SmartFishFarm1
{
    /// <summary>
    /// This is the class to collect and display alll sensor data
    /// </summary>
    class SensorIO
    {
        //define the data we need 
        byte sensor_id_temp = 12;
        string sensor_type_temp = "temp";
        string date_time_temp1 = "2020-10-18~10AM";//hard coded data, we should not use this
        double temp1 = 23.67;
        string date_time_temp2 = "2020-10-18~5PM";
        double temp2 = 21.00;
        //if we need to add another temp sensor, then we are in trouble
        //it is messy
        //byte sensor2_id_temp = 12;
        //string sensor2_type_temp = "temp";
        //string date_time_temp1 = "2020-10-18~10AM";//hard coded data, we should not use this
        //double temp1 = 23.67;
        //string date_time_temp2 = "2020-10-18~5PM";
        //double temp2 = 21.00;
        //SO WHAT SHOULD WE DO??

        //now ph sensor info
        byte sensor_id_ph = 20;
        string sensor_type_ph = "ph";
        string date_time_ph1 = "2020-10-18~10AM";
        double ph1 = 5.4;
        string date_time_ph2 = "2020-10-18~5PM";
        double ph2 = 3.00;

        /// <summary>
        /// This method is for collecting temparature data from sensor.
        /// It does not need any parameters
        /// </summary>
        private void collectTempData()
        {
            //make this more flexible by taking data input from users
            //now you will learn type conversion
            Console.WriteLine("Please enter first date and time for data - ");
            date_time_temp1 = Console.ReadLine();
            //read first temp - but it may cause exception if non-numeric input is given
            //handle exception
            try
            {
                Console.WriteLine("Please enter first temp - ");
                temp1 = double.Parse(Console.ReadLine());//in future - try-catch
                //but the following line should be checked as well and date_time_temp2
                //should be a Datetime type/object
                Console.WriteLine("Please enter second date and time for data - ");
                date_time_temp2 = Console.ReadLine();
                Console.WriteLine("Please enter second temp - ");
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

        }
        public void beginOperation()
        {
            //call method to collect temparature data
            collectTempData();
            //call method to collect Ph data
            collectPHData();
            //now display the data
            Console.WriteLine("Temp data 1 " + sensor_id_temp + "-" + sensor_type_temp
                            + " Date & time=" + date_time_temp1 + " Temp=" + temp1);
            Console.WriteLine("Temp data 2 " + sensor_id_temp + "-" + sensor_type_temp
                            + " Date & time=" + date_time_temp2 + " Temp=" + temp2);

        }
    }
}
