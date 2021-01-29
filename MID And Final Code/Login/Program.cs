using System;

namespace Login
{
    class Program
    {
        static string username, input,input1;
        static int password,id;
        static void register()
        {
            Console.WriteLine("Enter username: ");
            username = Console.ReadLine();
            Console.WriteLine("Enter username: ");
            input = Console.ReadLine();
            password = int.Parse(input);
            Console.WriteLine("Enter id: ");
            input1 = Console.ReadLine();
            id = int.Parse(input1);
            Console.WriteLine("Registration Successfully!!");
        }
        /**/
        static void login()
        {
            if(username==Console.ReadLine())
            {
                if(input==Console.ReadLine()/*|| password ==int.Parse(input)*/)
                {
                    if (input1 == Console.ReadLine() /*&& id == int.Parse(input)*/)Console.WriteLine("Login Successfully" + "\nUsername: " + username + "\nPassword: " + password + "\nID: " + id);
                    else Console.WriteLine("Wrong Id");
                }
                else
                {
                    Console.WriteLine("Plase re correct the passoword!!");
                }
            }
            else
            {
                Console.WriteLine("username incorrect!!");
            }
        }
        static void Main(string[] args)
        {
            while (true)
            {
                register();
                login();
            }

        }
    }
}
