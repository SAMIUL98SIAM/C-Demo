using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using SmartFishFarm2.io;
namespace SmartFishFarm2.alldata
{
    /// <summary>
    /// the ponds class
    /// it will contain all sensors
    /// it will have specific size
    /// The number of sensors will depend on pond size
    /// </summary>
    class SmartPondsWithFiles
    {
        /// <summary>
        /// the ponds class that saves sensor data in a file
        /// it will contain all sensors
        /// it will have specific size
        /// The number of sensors will depend on pond size
        /// The sensor data will be saved in the following format - 
        /// TEMP~55~2020-10-10:9AM~13.5
        /// PH~22~2020-10-10:10AM~7.5
        /// TEMP.....
        /// </summary>

        const int BIGPONDSENSORS = 10;
        const int MEDIUMPONDSENSORS = 6;
        const int SMALLPONDSENSORS = 4;
        PondSize mysize;
        int current_index = 0;
        int totalTempData, totalPHData, totalData;
        SmartFishFarm2.io.ISensorIO ioobj = null;
        //the file where we will keep all our sensor data saved
        const string SENSOR_FILE = @"D:\AIUB\C#\MID_Code\sensordat.txt";
        //create a constructor that will accept the size of the pond so that the array size can be determined
        public SmartPondsWithFiles(PondSize sz, SmartFishFarm2.io.ISensorIO io)
        {
            this.mysize = sz;
            this.ioobj = io;
            //BIG will have sensor data array with 10 elements
            //MEDIUM  will have sensor data array with 6 elements
            //SMALL  will have sensor data array with 4 element
            if (this.mysize == PondSize.BIG)
            {
                this.totalTempData = 5;
                this.totalPHData = 5;
                this.totalData = 10;
            }
            else if (this.mysize == PondSize.MEDIUM)
            {
                this.totalTempData = 3;
                this.totalPHData = 3;
                this.totalData = 6;
            }
            else
            {
                this.totalTempData = 2;
                this.totalPHData = 2;
                this.totalData = 4;
            }
            //check if data file exists - if not, then create it
            if (!File.Exists(SENSOR_FILE))
            {
                File.Create(SENSOR_FILE);
            }
        }

        public int getTotalTempData()
        {
            return this.totalTempData;
        }

        public void saveSensorData(Sensor sensordata)
        {
            //now data will be saved in file.
            StreamWriter sw = null;
            try
            {
                sw = new StreamWriter(SENSOR_FILE, true);
                string sensorinfo = sensordata.sensor_type + "~"
                                    + sensordata.sensor_id + "~"
                                    + sensordata.date_time + "~"
                                    + sensordata.data_value;
                sw.WriteLine(sensorinfo);
                ioobj.showMssg("Save Successfully");
            }
            catch (Exception e)
            {
                //Console.WriteLine("Error: " + e.Message);
                ioobj.showError(e.Message);
                
            }
            finally
            {
                sw.Close();
            }
        }

        public double getTempAverage()
        {
            //use for loop to print temp data and get temp average
            //please do remember - temp data may not be sequential
            double data_total = 0.0;
            StreamReader srd = null;
            string line = "";
            try
            {
                srd = new StreamReader(SENSOR_FILE);
                while (true)
                {
                    line = srd.ReadLine();
                    if (line == null)
                    {
                        break;
                    }
                    //nwo you have to get the data out from each line
                    //remember each line represent one sensor data (structure)
                }
            }
            catch (Exception e)
            { 
                Console.WriteLine("Error: " + e.Message);
            }
            finally
            {
                srd.Close();
            }
            //for (int i = 0; i < sensor_data.Length; i++)
            //{
            //    if (line[i]== sensortypes.TEMP)
            //    {
            //        Console.WriteLine("Temp data-> id:" + sensor_data[i].sensor_id + "-" + sensor_data[i].sensor_type
            //                        + " Date & time=" + sensor_data[i].date_time + " Temp=" + sensor_data[i].data_value);
            //        data_total += sensor_data[i].data_value;
            //    }
            //}
            return data_total / totalTempData;
        }
        //public double getPHAverage()
        //{
        //    //use for loop to print temp data and get temp average
        //    //please do remember - temp data may not be sequential
        //    double data_total = 0.0;
        //    StreamReader srd = new StreamReader(SENSOR_FILE);
        //    string line = "";
        //    line = srd.ReadLine();
        //    try
        //    {
                
        //        while (true)
        //        {
        //            line = srd.ReadLine();
        //            if (line == null)
        //            {
        //                break;
        //            }
        //            //nwo you have to get the data out from each line
        //            //remember each line represent one sensor data (structure)
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine("Error: " + e.Message);
        //    }
        //    finally
        //    {
        //        srd.Close();
        //    }
            //for (int i = 0; i < sensor_data.Length; i++)
            //{
            //    if (sensor_data[i].sensor_type == sensortypes.TEMP)
            //    {
            //        Console.WriteLine("Temp data-> id:" + sensor_data[i].sensor_id + "-" + sensor_data[i].sensor_type
            //                        + " Date & time=" + sensor_data[i].date_time + " Temp=" + sensor_data[i].data_value);
            //        data_total += sensor_data[i].data_value;
            //    }
            //}
         //   return data_total / totalTempData;
       // }
        public int getTotalData()
        {
            return this.totalData;
        }

        public int getTotalPHData()
        {
            return this.totalPHData;
        }

    }
}
