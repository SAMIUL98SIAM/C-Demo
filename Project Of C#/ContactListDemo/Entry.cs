using System;
using ContactListDemo.allData;
namespace ContactListDemo.io
{
    class Entry
    {
        static void Main(string[] args)
        {
           
            ParentSensorIOAbstract sio=null ;
            Console.WriteLine("SIMPLE_ARRAY\nNO_ARRAY");
            Console.WriteLine("What type of IO class you want to add in: ");
            string wtoi = Console.ReadLine();
            if (wtoi == "SIMPLE_ARRAY")
            {
                sio = new ContactIONoLogic();
            }
            else
            {
                sio = new ContactIO();
            }
            sio.showDetails();
        }
    }
}
