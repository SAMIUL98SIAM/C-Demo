using System;

namespace Car_Class
{
    class main
    {
        static void Main(string[] args)
        {
            Car porshei = new Car("Walter","Porshei","Red",12);
            porshei.introduceMySelf();
            Console.WriteLine("");
            Car bmw = new Car("Elon", "BMW", "Red");
            porshei.introduceMySelf();
            Console.WriteLine("");
            Car ford = new Car("Bill", "Ford");
            ford.introduceMySelf();
            Console.WriteLine("");
            Car tata = new Car("Roton");
            tata.introduceMySelf();
        }
    }
}
