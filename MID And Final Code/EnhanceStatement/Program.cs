using System;

namespace EnhanceStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 12, b = 14;
            string stta;
            stta = a > b ? " {0} is bigger than {1} ": "{1} is bigger than {0}";
            // if (a < b) ? Console.WriteLine("{0} is greater than {1}", b, a) : Console.WriteLine("{0} is greater than {1}", a, b);
            Console.WriteLine(stta);
        }
    }
}
