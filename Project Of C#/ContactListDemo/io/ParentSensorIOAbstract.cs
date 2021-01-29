using ContactListDemo.allData;
using System;
using System.Collections.Generic;
using System.Text;

namespace ContactListDemo.io
{
    abstract class ParentSensorIOAbstract
    {
        protected abstract void addContactData();
        protected abstract void show();
        protected abstract void searching_data();
        protected abstract void Delete_data();
        protected void showWelcomeMessage()
        {

            Console.WriteLine("Welcome to the contactList monitoring system");
            Console.WriteLine("--------------------------------------------");
        }
        public virtual void showDetails()
        {
            showWelcomeMessage();
            Console.WriteLine("Beginning operation.");
        }

        public static implicit operator ParentSensorIOAbstract(ContactIO v)
        {
            throw new NotImplementedException();
        }
    }
}
