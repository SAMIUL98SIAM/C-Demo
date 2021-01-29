using System;
using System.Collections.Generic;
using System.Text;
using ContactListDemo.allData;
namespace ContactListDemo.io
{
    class ContactIONoLogic:ParentSensorIOAbstract
    {
        SmartContact smartContact = null;
        Contact Contact;

        protected override void addContactData()
        {
            try
            {
                for(int i=0;i<smartContact.getTotalData(); i++)
                {

                    Console.Write("Enter Contactlist {0} Name -> ", i);
                    Contact.name = Console.ReadLine();
                    Console.Write("Enter the Family Contactlist {0} Phone -> ", i);
                    Contact.phone = int.Parse(Console.ReadLine());
                    Console.Write("Enter the Family Contactlist {0} Address -> ", i);
                    Contact.address = Console.ReadLine();
                    Console.Write("Enter the Relation(FM(FAMILY)/FR(FRIEND)/BS(BUSINESS)) -> ");
                    string inp_rln = Console.ReadLine();
                    if (inp_rln == "FM")
                    { 
                        Contact.relation_type = relationType.FAMILY; 
                    }
                    if(inp_rln == "FR")
                    {
                        Contact.relation_type = relationType.FRIEND;
                    }
                    if(inp_rln == "BS")
                    {
                        Contact.relation_type = relationType.BUSINESS;
                    }
                    smartContact.saveContactData(Contact);

                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
          
            }
        }
        
        public void addContact()
        {
            addContactData();
          
       
        }

        protected override void show()
        {
            smartContact.showtotalContact();
            
        }
        protected override void searching_data()
        {
            Console.WriteLine("Enter the name for searching: ");
            Contact.name = Console.ReadLine();
            smartContact.search_data(Contact.name);
        }
        protected override void Delete_data()
        {
            Console.WriteLine("Enter the name for deleting: ");
            Contact.name = Console.ReadLine();
            smartContact.delete(Contact.name);
        }

        public override void showDetails()
        {
            base.showDetails();
            smartContact = new SmartContact(ContactSize.SMALL);
            while (true)
            {
                Console.WriteLine("PRESS 1 FOR ADD OPTION");
                Console.WriteLine("PRESS 2 FOR SEARCH OPTION");
                Console.WriteLine("PRESS 3 FOR DELETE OPTION");
                Console.WriteLine("PRESS 4 FOR UPDATE OPTION");
                Console.WriteLine("Enter the option:");
                int inpt = int.Parse(Console.ReadLine());
                if (inpt == 1)
                {
                    addContact();
                    Console.WriteLine("\n\n");
                }
                else if(inpt == 2)
                {
                    searching_data();
                    Console.WriteLine("\n\n");
                }
                else if (inpt == 3)
                {
                    Delete_data();
                    Console.WriteLine("\n\n");
                }
                else if (inpt == 4)
                {
                    show();
                    Console.WriteLine("\n\n");
                }
                else if(inpt == 5)
                {
                    Console.WriteLine("Operation Closed!!");
                }
            }
          
        }

       
    }

   
}
