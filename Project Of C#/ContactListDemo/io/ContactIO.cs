using ContactListDemo.io;
using System;
using System.Collections.Generic;
using System.Text;
using ContactListDemo.io;
namespace ContactListDemo.allData
{
    class ContactIO 
    {
        Contact Contact;
        protected void addContactData()
        {
            try
            {

                Console.Write("Enter Contactlist 1 Name -> ");
                Contact.name = Console.ReadLine();
                Console.Write("Enter the Family Contactlist 1 Phone -> ");
                Contact.phone = int.Parse(Console.ReadLine());
                Console.Write("Enter the Family Contactlist 1 Address -> ");
                Contact.address = Console.ReadLine();
                Console.Write("Enter the Relation(FM(FAMILY)/FR(FRIEND)/BS(BUSINESS)) -> ");
                string inp_rln = Console.ReadLine();
                if (inp_rln == "FM")
                {
                    Contact.relation_type = relationType.FAMILY;
                }
                if (inp_rln == "FR")
                {
                    Contact.relation_type = relationType.FRIEND;
                }
                if (inp_rln == "BS")
                {
                    Contact.relation_type = relationType.BUSINESS;
                }
                Console.Write("Enter Contactlist 1 Name -> ");
                Contact.name = Console.ReadLine();
                Console.Write("Enter the Family Contactlist 1 Phone -> ");
                Contact.phone = int.Parse(Console.ReadLine());
                Console.Write("Enter the Family Contactlist 1 Address -> ");
                Contact.address = Console.ReadLine();
                Console.Write("Enter the Relation(FM(FAMILY)/FR(FRIEND)/BS(BUSINESS)) -> ");
                inp_rln = Console.ReadLine();
                if (inp_rln == "FM")
                {
                    Contact.relation_type = relationType.FAMILY;
                }
                if (inp_rln == "FR")
                {
                    Contact.relation_type = relationType.FRIEND;
                }
                if (inp_rln == "BS")
                {
                    Contact.relation_type = relationType.BUSINESS;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
        protected void show()
        {
            Console.WriteLine(
                     "Name: " + Contact.name +
                     "\nAddress: " + Contact.address +
                     "\nPhone: " + Contact.phone +
                     "\nRelation Type: " + Contact.relation_type);
        }
       


        public void showDetails()
        {
            while (true)
            {
                Console.WriteLine("PRESS 1 FOR ADD OPTION");        
                Console.WriteLine("PRESS 2 FOR UPDATE OPTION");
                Console.WriteLine("PRESS 3 FOR TURNED OFF OPTION");
                Console.WriteLine("Enter the option:");
                int inpt = int.Parse(Console.ReadLine());
                if (inpt == 1)
                {
                    addContactData();
                }
                else if (inpt == 2)
                {
                    show();
                }
                else if (inpt == 3)
                {
                    Console.WriteLine("Operation Closed!!");
                }
            }

        }
    }
}
