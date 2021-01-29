using System;
using System.Collections.Generic;
using System.Text;
using BankManageMent.AllData;
namespace BankManageMent
{
    class SensorIo : ParentIOAbstract
    {
        Sensor empsensor, mngsensor;
     
        protected override void empData()
        {
            try 
            {
                Console.Write("Enter the Employ id = ");
                empsensor.sensor_id = Byte.Parse(Console.ReadLine());
                //Console.Write("Enter the sensor type = ");
                empsensor.sensor_type = sensortype.employee;
                Console.WriteLine("Enter the salary = ");
                empsensor.salary = Double.Parse(Console.ReadLine());
                Console.WriteLine("Entre the data of birth = ");
                empsensor.dOfb = Console.ReadLine();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        protected override void mngrData()
        {
            try 
            {
                Console.Write("Enter the Manager id = ");
                mngsensor.sensor_id = Byte.Parse(Console.ReadLine());
                //Console.Write("Enter the sensor type = ");
                mngsensor.sensor_type = sensortype.manager;
                Console.WriteLine("Enter the salary = ");
                mngsensor.salary = Double.Parse(Console.ReadLine());
                Console.WriteLine("Entre the data of birth = ");
                mngsensor.dOfb = Console.ReadLine();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message); 
            }
            
        }
        public void showDetails()
        {
            // base.showDetails();
            Console.ReadKey();
            empData();
            //mngrData();
            double total_Salary = 0.0;
            Console.WriteLine("Employee Id = {0} \nType = {1} \nSalary = {2} \nDate of Birth = {3} ", empsensor.sensor_id, empsensor.sensor_type, empsensor.salary, empsensor.dOfb);
            total_Salary += empsensor.salary;
            /*if (empsensor.sensor_type ==sensortype.employee)
            {
               
            }
           // Console.WriteLine("Total Employee's Salary: " + total_Salary);
            if (mngsensor.sensor_type == sensortype.manager)
            {
                Console.WriteLine("Manager Id = {0} \nType = {1} \nSalary = {2} \nDate of Birth = {3} ", mngsensor.sensor_id, mngsensor.sensor_type, mngsensor.salary, mngsensor.dOfb);
                total_Salary += mngsensor.salary;
            }*/
            //Console.WriteLine("Total Employee's Salary: " + total_Salary);


            Console.WriteLine();

        }
    }
}
