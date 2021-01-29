using System;

namespace InheritenceDemo
{
    class Animals
    {

        private string name;
       // private string type;
        private int legs;
        public string type { get; set; }
        public int Legs 
        {
            get
            {
                return legs;
            }
            set
            {
                if(legs<=4)
                {
                    legs = value;
                }
                else
                {
                    Console.WriteLine("Animals can't contains {0} leg", legs);
                }
            }
        }
        public String Name
        {
            get
            {
                return name;
            }
            set
            {
                try { 
                        if (name == "")
                        {
                           name = "Empty";  
                        }
                        else
                        {
                             name = value;
                        }
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        public void showDetails()
        {
            Console.WriteLine("Name: {0} \nType: {1} \nLegs: {2}", Name, type, Legs);
        }

        
    }
}
