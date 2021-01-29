using System;
using System.Collections.Generic;
using System.Text;
using ContactListDemo.allData;
using ContactListDemo.io;
namespace ContactListDemo
{
    class SmartContact
    {
        Contact arr;
        ContactSize contactSize;
        Contact[] contact_arr_data;
        const int BIGCONTACTSIZE = 12;
        const int SMALLCONTACTSIZE = 6;
        int totalData;
        int count = 0;
        public SmartContact(ContactSize contactSize)
        {
           
            this.contactSize = contactSize;
            if(this.contactSize == ContactSize.BIG)
            {
                contact_arr_data = new Contact[BIGCONTACTSIZE];
                this.totalData = 12;
                //this.totalBusinessContactdata=6;
                //this.totalFriendContactData = 6;
                //this.totalFamilyContactdata = 4;
            }
            else
            {
                contact_arr_data = new Contact[SMALLCONTACTSIZE];
                this.totalData = 3;
                //this.totalBusinessContactdata = 3;
                //this.totalFriendContactData = 4;
                //this.totalFamilyContactdata = 2;

            }
        }
        public int getTotalData()
        {
            return this.totalData;
        }

        //public int getBusinessContactTotalData()
        //{
        //    return this.totalBusinessContactdata;
        //}
        public void saveContactData(Contact contactData)
        {
            contact_arr_data[count] = contactData;
            count++;
        }
        public void delete(string name)
        {
            bool c1 = false;
           
            for (int i = 0; i < count; i++)
            {
                if (contact_arr_data[i].name.Contains(name))
                {
                    c1 = true;
                    Console.WriteLine("Deleted!!");
                    for(int j=i;j<count;j++)
                    {
                        contact_arr_data[j] = contact_arr_data[j + 1];
                    }
                    count--;
                    break;
                }
               
            }
            if(c1 == false) { Console.WriteLine("NOT FOUND!!"); }
        }

        public void search_data(string name)
        {
            int flag = 0;
            for (int i = 0; i < this.totalData; i++)
            {
                if (contact_arr_data[i].name == name)
                {
                    flag = 1;
                    Console.WriteLine("Found it");
                    Console.WriteLine(
                    "Name: " + contact_arr_data[i].name +
                    "\nAddress: " + contact_arr_data[i].address +
                    "\nPhone: " + contact_arr_data[i].phone +
                    "\nRelation Type: " + contact_arr_data[i].relation_type
                    );
                }
            }

        }

 

        public void showtotalContact()
        {
            for(int i=0;i<this.totalData;i++)
            {
                
                 Console.WriteLine(
                     "Name: " + contact_arr_data[i].name + 
                     "\nAddress: " + contact_arr_data[i].address + 
                     "\nPhone: " + contact_arr_data[i].phone +
                     "\nRelation Type: " + contact_arr_data[i].relation_type);
                Console.WriteLine("\n");
                
            }
        }

      
       
    }
}
