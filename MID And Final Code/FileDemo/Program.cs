using System;
using System.IO;

namespace FileDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                WriteTxt();
                ReadTxt();
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                Console.ReadKey();
                throw;
            }
        }


        static void WriteTxt()
        {
            Console.WriteLine("Writibg: ");
            StreamWriter streamWriter = new StreamWriter("D:/C#/MID_Code/FileDemo/X.txt");
            streamWriter.WriteLine("Hello 4!!");
            streamWriter.Close();
           
        }

        static void ReadTxt()
        {
            Console.WriteLine("Reading");
            StreamReader streamReader = new StreamReader("D:/C#/MID_Code/FileDemo/X.txt");
            string line = streamReader.ReadLine();
            while(line!=null)
            {
                Console.WriteLine(line);
                line = streamReader.ReadLine();
            }
            streamReader.Close();
        }

    }
}
