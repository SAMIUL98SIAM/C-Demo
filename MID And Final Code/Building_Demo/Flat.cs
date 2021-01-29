using System;
using System.Collections.Generic;
using System.Text;

namespace Building_Demo
{

    class Flat : Room
    {
        private int field { get; set; }
        private double fCost=0.0;

        public Flat(string owner, int kitchen, int bedRoom, int washRoom,int filed):base(owner,kitchen,bedRoom,washRoom)
        {
            this.field = field;
            fCost = (121 * Kitchen + 45 * BedRoom + 12 * washRoom+2*filed)+Cost;
        }
       public void showDetails()
        {
            Console.WriteLine("Flat Owner: " + Owner);
            Console.WriteLine("Flat Kitchen: " + Kitchen);
            Console.WriteLine("Flat BedRoom: " + BedRoom);
            Console.WriteLine("Flat Washroom: " + WashRoom);
            Console.WriteLine("Flat Filed: " + field);
            Console.WriteLine("Total Cost: " + Cost);
            Console.WriteLine("Total Flat Cost: " + fCost);
        }
    }
}
