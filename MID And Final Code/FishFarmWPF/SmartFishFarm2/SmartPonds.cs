using System;
using System.Collections.Generic;
using System.Text;

namespace SmartFishFarm2.alldata
{
    /// <summary>
    /// the ponds class
    /// it will contain all sensors
    /// it will have specific size
    /// The number of sensors will depend on pond size
    /// </summary>
    class SmartPonds
    {
        PondSize pondSize;
        Sensor[] sensor_arr_data;
        const int BIGPONDSENSORS = 10;
        const int MIDPONDSENSORS = 6;
        const int SMALLPONDSENSORS = 4;
        int totalTempData, totalPHData, totalData;
        int current_index = 0;
        public SmartPonds(PondSize pondSize)
        {
            this.pondSize = pondSize;
            if (this.pondSize == PondSize.BIG)
            {
                sensor_arr_data = new Sensor[BIGPONDSENSORS];
                this.totalTempData = 5;
                this.totalPHData = 5;
                this.totalData = 10;
            }
            else if (this.pondSize == PondSize.MEDIUM)
            {
                sensor_arr_data = new Sensor[MIDPONDSENSORS];
                this.totalTempData = 3;
                this.totalPHData = 3;
                this.totalData = 6;
            }
            else
            {
                sensor_arr_data = new Sensor[SMALLPONDSENSORS];
                this.totalTempData = 2;
                this.totalPHData = 2;
                this.totalData = 4;
            }
        }

        public int getTotalData()
        {
            return this.totalData;
        }
        public int getTotalTempData()
        {
            return this.totalTempData;
        }
        public int getTotalPHData()
        {
            return this.totalPHData;
        }
        //declare the array to hold the sensor data array
        //create a constructor that will accept the size of the pond so that the array size can be determined
        public void saveSensorData(Sensor sensordata)
        {
            //THERE WILL BE SUBTLE ERROR WITH ARRAY INDEX BEING OUT OF BOUNDS - YOU NEED TO ACCOUNT FOR IT
            sensor_arr_data[current_index] = sensordata;
            current_index++;
        }
        public double getTempAverage()
        {
            //use for loop to print temp data and get temp average
            //please do remember - temp data may not be sequential
            double data_total = 0.0;
            for (int i = 0; i < this.totalTempData; i++)
            {
                if (sensor_arr_data[i].sensor_type == sensortypes.TEMP)
                {
                    Console.WriteLine("Temp data-> id:" + sensor_arr_data[i].sensor_id + "-" + sensor_arr_data[i].sensor_type
                                    + " Date & time=" + sensor_arr_data[i].date_time + " Temp=" + sensor_arr_data[i].data_value);
                    data_total += sensor_arr_data[i].data_value;
                }
            }
            return data_total / totalTempData;
        }
        public double getPhAverage()
        {
            //use for loop to print temp data and get temp average
            //please do remember - temp data may not be sequential
            double data_total = 0.0;
            for (int i = this.totalTempData; i < this.totalData; i++)
            {
                if (sensor_arr_data[i].sensor_type == sensortypes.PH)
                {
                    Console.WriteLine("Temp data-> id:" + sensor_arr_data[i].sensor_id + "-" + sensor_arr_data[i].sensor_type
                                    + " Date & time=" + sensor_arr_data[i].date_time + " Ph=" + sensor_arr_data[i].data_value);
                    data_total += sensor_arr_data[i].data_value;
                }
            }
            return data_total / totalTempData;
        }
    }
}
