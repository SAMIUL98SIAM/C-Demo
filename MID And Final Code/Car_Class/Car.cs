using System;
using System.Collections.Generic;
using System.Text;

namespace Car_Class
{
    class Car
    {
        private string car_owner;
        private string car_brand;
        private string color;
        private int wheel;
        public Car()
        {
            Console.WriteLine("This is empty");
        }
        public Car(string car_owner,string car_brand,string color ,int wheel)
        {
            this.car_owner = car_owner;
            this.car_brand = car_brand;
            this.color = color;
            this.wheel = wheel;
        }
        public Car(string car_owner, string car_brand, string color)
        {
            this.car_owner = car_owner;
            this.car_brand = car_brand;
            this.color = color;
        }
        public Car(string car_owner, string car_brand)
        {
            this.car_owner = car_owner;
            this.car_brand = car_brand;
        }
        public Car(string car_owner)
        {
            this.car_owner = car_owner;
        }

        public void introduceMySelf()
        {
            if (car_owner != null && car_brand != null && color != null & wheel != 0)
            {
                Console.WriteLine("This is {0} .\nHis Car brand is {1} .\nCar color is {2} .\nNumber of wheels of the car are {3}", car_owner, car_brand, color, wheel);
            }
            else if (car_owner != null && car_brand != null && color != null)
            {
                Console.WriteLine("This is {0} .\nHis Car brand is {1} .\nCar color is {2} .", car_owner, car_brand, color);
            }
            else if (car_owner != null && car_brand != null)
            {
                Console.WriteLine("This is {0} .\nHis Car brand is {1} .", car_owner, car_brand);
            }
            else if (car_owner != null)
            {
                Console.WriteLine("This is {0} .", car_owner);
            }

        }

    }
}
