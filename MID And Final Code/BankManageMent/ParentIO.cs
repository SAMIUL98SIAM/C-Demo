using System;
using System.Collections.Generic;
using System.Text;

namespace BankManageMent
{
    class ParentSensorIO
    {
        protected virtual void empData()
        {
            Console.WriteLine("Starting temparaturre sensor data collection.");
        }

        protected virtual void mngrData()
        {
            Console.WriteLine("Starting PH sensor data collection.");
        }

        public virtual void showDetails()
        {
            showWelcomeMassage();
            Console.WriteLine("Beginning operation.");
        }

        protected void showWelcomeMassage()
        {
           Console.WriteLine("welcome to sensor program.");
       /*     Console.WriteLine("Welcome to the bank management system");
            Console.WriteLine("-------------------------------------");*/
        }
    }
}
