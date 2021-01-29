using System;
using System.Collections.Generic;
using System.Text;
using BankManageMent.AllData;
namespace BankManageMent
{
    abstract class ParentIOAbstract
    {
        protected abstract void empData();
        protected abstract void mngrData();
        public void showDetails()
        {
            showWelcomeMassage();
            Console.WriteLine("Now begin the operation");
        }
        protected void showWelcomeMassage()
        {
            Console.WriteLine("welcome to sensor program.");
       /*     Console.WriteLine("Welcome to the bank management system");
            Console.WriteLine("-------------------------------------");*/
        }
    }
}
