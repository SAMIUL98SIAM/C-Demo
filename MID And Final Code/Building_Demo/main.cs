using System;
using System.Collections.Generic;
using System.Text;

namespace Building_Demo
{
    class main
    {
        public static void Main(String[] args)
        {
 /*           Room room = new Room("DickSon",1,2,1);

            room.showDetails();*/
            Flat flat = new Flat("DickSon", 1, 2, 1, 3);
            flat.showDetails();
        }
    }
}
