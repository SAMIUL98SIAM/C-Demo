//using System;
//using System.IO;
//using SmartFishFarm2.alldata;

//namespace SmartFishFarm2
//{
//    /// <summary>
//    /// the ponds class that saves sensor data in a file
//    /// it will contain all sensors
//    /// it will have specific size
//    /// The number of sensors will depend on pond size
//    /// The sensor data will be saved in the following format - 
//    /// TEMP~55~2020-10-10:9AM~13.5
//    /// PH~22~2020-10-10:10AM~7.5
//    /// TEMP.....
//    /// </summary>
//    class SmartPondsWithFile
//    {
//        const int BIGPONDSENSORS = 10;
//        const int MEDIUMPONDSENSORS = 6;
//        const int SMALLPONDSENSORS = 4;
//        PondSize mysize;
//        int current_index = 0;
//        int totalTempData;

//        //ui class reference
//        SmartFishFarm2.io.ISensorIO ioobj = null;

//        //the file where we will keep all our sensor data saved
//        const string SENSOR_FILE = @"d:\RUA\sensordat.txt";
//        //create a constructor that will accept the size of the pond so that the array size can be determined
//        public SmartPondsWithFile(PondSize sz, SmartFishFarm2.io.ISensorIO io)
//        {
//            this.mysize = sz;
//            this.ioobj = io;
//            //BIG will have sensor data array with 10 elements
//            //MEDIUM  will have sensor data array with 6 elements
//            //SMALL  will have sensor data array with 4 element
//            if (this.mysize == PondSize.BIG)
//            {
//                this.totalTempData = 5;
//            }
//            else if (this.mysize == PondSize.MEDIUM)
//            {
//                this.totalTempData = 3;
//            }
//            else
//            {
//                this.totalTempData = 2;
//            }
//            //check if data file exists - if not, then create it
//            if (!File.Exists(SENSOR_FILE))
//            {
//                File.Create(SENSOR_FILE);
//            }
//        }

//        public int getTotalTempData()
//        {
//            return this.totalTempData;
//        }

//        public void saveSensorData(Sensor sensordata)
//        {
//            //now data will be saved in file.
//            StreamWriter sw = null;
//            try
//            {
//                sw = new StreamWriter(SENSOR_FILE, true);
//                string sensorinfo = sensordata.sensor_type + "~"
//                                    + sensordata.sensor_id + "~"
//                                    + sensordata.date_time + "~"
//                                    + sensordata.data_value;
//                sw.WriteLine(sensorinfo);
//                ioobj.showMessage("Sensor data saved successfully.");
//            }
//            catch (Exception e)
//            {
//                //Console.WriteLine("Error: " + e.Message);
//                ioobj.showError(e.Message);
//            }
//            finally
//            {
//                sw.Close();
//            }
//        }

//        public double getTempAverage()
//        {
//            //use for loop to print temp data and get temp average
//            //please do remember - temp data may not be sequential
//            double data_total = 0.0;
//            string line = "";
//            try
//            {
//                StreamReader srd = new StreamReader(SENSOR_FILE);
//                while (true)
//                {
//                    line = srd.ReadLine();
//                    if (line == null)
//                    {
//                        break;
//                    }
//                    //nwo you have to get the data out from each line
//                    //remember each line represent one sensor data (structure)
//                    string[] dat = line.Split("~");
//                    dat[0] //this is the sensro type
//                    dat[1] //id
//                    dat[2] //data and time
//                    dat[3]  //data
//                    if (dat[0].Equals(sensortypes.TEMP.ToString()))
//                    {

//                    }
//                }
//            }
//            catch (Exception e)
//            {

//            }
//            finally
//            {

//            }
//            for (int i = 0; i < sensor_data.Length; i++)
//            {
//                if (sensor_data[i].sensor_type == sensortypes.TEMP)
//                {
//                    Console.WriteLine("Temp data-> id:" + sensor_data[i].sensor_id + "-" + sensor_data[i].sensor_type
//                                    + " Date & time=" + sensor_data[i].date_time + " Temp=" + sensor_data[i].data_value);
//                    data_total += sensor_data[i].data_value;
//                }
//            }
//            return data_total / totalTempData;
//        }

//        internal int getTotalPHData()
//        {
//            throw new NotImplementedException();
//        }
//    }
//}
