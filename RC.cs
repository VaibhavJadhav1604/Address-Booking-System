using System;
using System.Collections.Generic;

namespace RemoveContact
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
        public void EditDetails()
        {
            Console.Write("Enter The Name Of Contact You Have To Edit:");
            string name = Console.ReadLine();
            foreach (var data in list)
            {
                if (data.firstname == name)
                {
                    Console.WriteLine("1.First Name" + "\n" + "2.Last Name" + "\n" + "3.Address" + "\n" + "4.City" + "\n" + "5.State" + "\n" + "6.ZipCode" + "\n" + "7.Mobile Number");
                    int opt = Convert.ToInt32(Console.ReadLine());
                    switch (opt)
                    {
                        case 1:
                            Console.Write("Enter First Name:");
                            string fname = Console.ReadLine();
                            data.firstname = fname;
                            break;

                        case 2:
                            Console.Write("Enter Last Name:");
                            string lname = Console.ReadLine();
                            data.lastname = lname;
                            break;

                        case 3:
                            Console.Write("Enter Address:");
                            string addr = Console.ReadLine();
                            data.address = addr;
                            break;

                        case 4:
                            Console.Write("Enter City:");
                            string cty = Console.ReadLine();
                            data.city = cty;
                            break;

                        case 5:
                            Console.Write("Enter State:");
                            string stt = Console.ReadLine();
                            data.state = stt;
                            break;

                        case 6:
                            Console.Write("Enter ZipCode:");
                            int zcode = Convert.ToInt32(Console.ReadLine());
                            data.zipcode = zcode;
                            break;

                        case 7:
                            Console.Write("Enter Mobile Number:");
                            long mnum = Convert.ToInt64(Console.ReadLine());
                            data.mobnum = mnum;
                            break;
                    }
                    Console.WriteLine("Contact Edited SuccessFully");
                }
                else
                {
                    Console.WriteLine("No Data Found Of Given Name:" + name);
                }
            }
        }
        public void RemoveDetails()
        {
            Console.Write("Enter The Name Of Contact You Have To Edit:");
            string name = Console.ReadLine();
            foreach (var data in list)
            {
                if (data.firstname == name)
                {
                    list.Remove(data);
                    Console.WriteLine("Contact Deleted SuccessFully");
                    break;
                }
                else
                {
                    Console.WriteLine("Contact Not Found");
                }
            }
        }
        internal class RC
        {
            public void switchcase()
            {
                Console.WriteLine("1.Add" + "\n" + "2.Display" + "\n" + "3.Edit" + "\n" + "4.Remove");
                Console.Write("Enter Option:");
                int opt = Convert.ToInt32(Console.ReadLine());
                switch (opt)
                {
                    case 1:
                        obj.AcceptDetails();
                        obj.DisplayDetails();
                        break;

                    case 2:
                        obj.DisplayDetails();
                        break;

                    case 3:
                        obj.EditDetails();
                        obj.DisplayDetails();
                        break;

                    case 4:
                        obj.RemoveDetails();
                        break;
                }
            }

            GetDetailsContact obj = new GetDetailsContact();

            static void Main(string[] args)
            {
                RC ob = new RC();
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
}
