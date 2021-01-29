using System;
using BankManageMent.AllData;
namespace BankManageMent
{
    class EntryPoint
    {
        public static void Main(string[] args)
        {
            ParentIOAbstract sio = null;
            sio = new SensorIo();
            sio.showDetails();
        }
    }
}
