using System;

namespace Calculator1
{
    class Program
    {
        public static double addition(double a1,double a2)
        {
            return a1 + a2;
        }
        public static double subtraction(double a1, double a2)
        {
            return a1 - a2;
        }
        public static double  multiplication(double a1, double a2)
        {
            return a1 * a2;
        }
        public static double division(double a1, double a2)
        {
            return a1 / a2;
        }
         static void Main(string[] args)
        {
           
         
            while (true)
            {
                String  character;
                double num1, num2,output=0;
                Console.WriteLine("PRESS (+) FOR ADDITION");
                Console.WriteLine("PRESS (-) FOR SUBTRACTION");
                Console.WriteLine("PRESS (*) FOR MULTUPLICATTION");
                Console.WriteLine("PRESS (/) FOR DIVISION");
                Console.WriteLine("PRESS (%) FOR REMINDER");
                Console.WriteLine("PRESS (X^2) FOR SQUARE");
                Console.WriteLine("PRESS (X^3) FOR QUBE");
                Console.WriteLine("PRESS (X^4) FOR X TO THE POWER 4");
                Console.WriteLine("PRESS (log) FOR LOGARITHM");
                Console.WriteLine("PRESS (log10) FOR LOGARITHM 10");
                Console.WriteLine("PRESS (exp) FOR EXPONENSIAL");
                Console.WriteLine("PRESS (100%) FOR PERSENATAGE");
                Console.WriteLine("\n\n\n\n\n");
                Console.WriteLine("Enter the the option: ");
                character = Console.ReadLine();
               
                if(character=="+")
                {
                    Console.WriteLine("\t\t\tWelcome to Addition");
                    Console.WriteLine("Enter the First number: ");
                  
                    num1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the Second number: ");
                  
                    num2 = double.Parse(Console.ReadLine());
                    output = num1 + num2;
                    Console.WriteLine(num1 + " " + character + " " + num2 + " = " + output);
                }
                else if(character=="-")
                {
                    Console.WriteLine("Enter the First number: ");
           
                    num1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the Second number: ");
                   
                    num2 = double.Parse(Console.ReadLine());
                    output = num1 - num2;
                    Console.WriteLine(num1 + " " + character + " " + num2 + " = " + output);
                }
                else if (character == "*")
                {
                    Console.WriteLine("Enter the First number: ");
                 
                    num1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the Second number: ");
                
                    num2 = double.Parse(Console.ReadLine());
                    output = num1 * num2;
                    Console.WriteLine("{0} {1} {2} = {3}", num1, character, num2, output);
                    //Console.WriteLine(num1 + " " + character + " " + num2 + " = " + output);
                }
                else if (character == "/")
                {
                    try
                    {  
                        Console.WriteLine("Enter the First number: ");
             
                        num1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the Second number: ");
                        
                        num2 = double.Parse(Console.ReadLine());
                        output = num1 / num2;
                        Console.WriteLine("{0} {1} {2} = {3}", num1, character,num2,output);
                        //Console.WriteLine(num1 + " " + character + " " + num2 + " = " + output);
                    }
                    catch(ArithmeticException ex)
                    {
                        Console.WriteLine(ex);
                        Console.WriteLine("Any Number cant divide by 0\nIf did divide , you'll get arithmetic exception");
                    }
                }
                else if (character == "%")
                {
                    try
                    {
                        Console.WriteLine("Enter the First number: ");

                        num1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the Second number: ");

                        num2 = double.Parse(Console.ReadLine());
                        output = num1 % num2;
                        Console.WriteLine("{0} {1} {2} = {3}", num1, character, num2, output);
                        //Console.WriteLine(num1 + " " + character + " " + num2 + " = " + output);
                    }
                    catch (ArithmeticException ex)
                    {
                        Console.WriteLine(ex);
                        Console.WriteLine("Any Number cant divide by 0\nIf did divide , you'll get arithmetic exception");
                    }
                }

                else if (character == "X^2")
                {
                    Console.WriteLine("Enter the First number: ");
                 
                    num1 = double.Parse(Console.ReadLine());
                    output = Math.Pow(num1, 2);
                    Console.WriteLine(num1+" to the power 2 = "+output);
                }
                else if (character == "X^3")
                {
                    Console.WriteLine("Enter the First number: ");
            
                    num1 = double.Parse(Console.ReadLine());
                    output = Math.Pow(num1, 3);
                    Console.WriteLine(num1 + " to the power 3 = " +output);
                }
                else if (character == "X^4")
                {
                    Console.WriteLine("Enter the First number: ");
                 
                    num1 = double.Parse(Console.ReadLine());
                    output = Math.Pow(num1, 4);
                    Console.WriteLine(num1 + " to the power 4 = " +output);
                }
                else if (character == "X^N")
                {
                    Console.WriteLine("Enter the First number: ");
                    num1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the Second number: ");

                    num2 = double.Parse(Console.ReadLine());
                    output = Math.Pow(num1, num2);
                    Console.WriteLine(num1 + " to the power "+num2+ " = " + output);
                }
                else if (character == "log")
                {
                    Console.WriteLine("Enter the First number: ");
   
                    num1 = double.Parse(Console.ReadLine());
                    /*Console.WriteLine("Enter the Second number: ");
                    input2 = Console.ReadLine();
                    num2 = double.Parse(input2)*/
                    output = Math.Log(num1);
                    Console.WriteLine("Log ( "+num1+" ) = "+ output);
                }
                else if (character == "log10")
                {
                    Console.WriteLine("Enter the First number: ");
            
                    num1 = double.Parse(Console.ReadLine());
                    /*Console.WriteLine("Enter the Second number: ");
                    input2 = Console.ReadLine();
                    num2 = double.Parse(input2)*/
                    output = Math.Log10(num1);
                    Console.WriteLine("Log10 ( " + num1 + " ) = " + output);
                }
                else if (character == "exp")
                {
                    Console.WriteLine("Enter the First number: ");
                   
                    num1 = double.Parse(Console.ReadLine());
                    /*Console.WriteLine("Enter the Second number: ");
                    input2 = Console.ReadLine();
                    num2 = double.Parse(input2)*/
                    output = Math.Exp(num1);
                    Console.WriteLine("Exp ({0}) = {1}",num1,output);
                    //Console.WriteLine("Exp (  " + num1 + " ) = " + output);
                }

            }

            
        }
    }
}
