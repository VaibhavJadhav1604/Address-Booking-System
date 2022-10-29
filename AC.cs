using System;
using System.Collections.Generic;

namespace AddContact
{
    public class Contact
    {
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public int zipcode { get; set; }
        public long mobnum { get; set; }
    }
    public class GetDetailsContact
    {
        List<Contact> list = new List<Contact>();
        Contact contact = new Contact();
        public void AcceptDetails()
        {
            Console.Write("Enter First Name:");
            contact.firstname = Console.ReadLine();

            Console.Write("Enter Last Name:");
            contact.lastname = Console.ReadLine();

            Console.Write("Enter Address:");
            contact.address = Console.ReadLine();

            Console.Write("Enter City:");
            contact.city = Console.ReadLine();

            Console.Write("Enter State:");
            contact.state = Console.ReadLine();

            Console.Write("Enter ZipCode:");
            contact.zipcode = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Mobile Number:");
            contact.mobnum = Convert.ToInt64(Console.ReadLine());

            list.Add(contact);
            Console.WriteLine("Data Inserted SuccessFully");
        }
        public void DisplayDetails()
        {
            foreach (var data in list)
            {
                if (list.Contains(data))
                {
                    Console.WriteLine("-------------Details-------------");
                    Console.WriteLine("First Name:" + data.firstname);
                    Console.WriteLine("Last Name:" + data.lastname);
                    Console.WriteLine("Address:" + data.address);
                    Console.WriteLine("City:" + data.city);
                    Console.WriteLine("State:" + data.state);
                    Console.WriteLine("ZipCode:" + data.zipcode);
                    Console.WriteLine("Mobile Number:" + data.mobnum);
                }
            }
        }
    }
    internal class AC
    {
        public void switchcase()
        {
            Console.WriteLine("1.Add" + "\n" + "2.Display");
            Console.Write("Enter Option:");
            int opt = Convert.ToInt32(Console.ReadLine());
            switch (opt)
            {
                case 1:
                    obj.AcceptDetails();
                    break;

                case 2:
                    obj.DisplayDetails();
                    break;
            }
        }

        GetDetailsContact obj = new GetDetailsContact();

        static void Main(string[] args)
        {
            AC ob = new AC();
            ob.switchcase();
            Console.Write("Do You Want To Do Anything Else(y/n):");
            string abc = Console.ReadLine();
            if (abc == "y")
            {
                ob.switchcase();
            }
            else if (abc != "n")
            {
                Console.WriteLine("You Have Given Wrong Value");
            }
            else
            {

            }
        }
    }
}
