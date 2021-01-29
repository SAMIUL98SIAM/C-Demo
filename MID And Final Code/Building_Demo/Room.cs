using System;

namespace Building_Demo
{
    class Room
    {
        private string owner;
        private int kitchen;
        private int bedRoom;
        private int washRoom {set; get;}
        private double cost;

        public Room(string owner,int kitchen,int bedRoom,int washRoom)
        {
            this.owner = owner;
            this.Kitchen = kitchen;
            this.BedRoom = bedRoom;
            this.washRoom = washRoom;
            cost = (121 * Kitchen + 45 * BedRoom + 12 * washRoom);
        }
        public double Cost { set 
            { cost = (121 * Kitchen + 45 * BedRoom + 12 * washRoom); }
            get
            {
                return cost;
            }
        }
        public void setOwner(string owner)
        {
            this.owner = owner;
        }
        public string getOwner()
        {
            return owner;
        }
        public String Owner { get => owner; set => owner = value; }
        public int Kitchen 
        {
            get 
            {
                return kitchen; 
            }
            set
            {
                kitchen = value;
            }
        }
        public int BedRoom
        {
            get
            {
                return bedRoom;
            }
            set
            {
                bedRoom = value;
            }
        }

        public int WashRoom 
        {
            set => washRoom = value;
            get=> washRoom;
        }
        public void showDetails()
        {
            Console.WriteLine("Room Owner: " +Owner);
            Console.WriteLine("Room Kitchen: " + Kitchen);
            Console.WriteLine("Room BedRoom: " + BedRoom);
            Console.WriteLine("Room Washroom: " + washRoom);
            
            Console.WriteLine("Total Cost: " + cost);
        }

    }
}
