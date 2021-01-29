using System;
using System.Collections.Generic;
using System.Text;

namespace InheritenceDemo
{
    class main
    {
        static void Main(String[] args)
        {
            Animals animals = new Animals();
            animals.Name = "";
            animals.type = "Mamals";
            animals.Legs = 10;
            animals.showDetails();
        }
    }
}
