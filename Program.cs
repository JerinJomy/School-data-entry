using System;

namespace Staffs
{
    class Program
    {
        static void Main(string[] args)
        {
            string select;
            do
            {
                Console.WriteLine("\nENTER '1' FOR DATA ENTRY\nENTER '2' TO VIEW  DETAILS OF ALL STAFF\nENTER '3' TO VIEW STAFF DETAILS IN SPECIFIC\nENTER '4' TO DELETE STAFF DETAILS\nENTER '5' TO UPDATE STAFF DETAILS \nENTER '9' TO EXIT");
                select = Console.ReadLine();
                switch (select)
                {
                    case "1":
                        EnterData( null);
                        break;
                    case "2":
                        Operation.view();
                        break;
                    case "3":
                        Console.WriteLine("ENTER THE STAFF id");
                        int idv = Convert.ToInt32(Console.ReadLine());
                        Operation.ViewOne(idv);
                        break;
                    case "4":
                        Console.WriteLine("ENTER THE STAFF id");
                        int idd = Convert.ToInt32(Console.ReadLine());
                        Operation.Delete(idd);
                        break;
                    case "5":
                        Console.WriteLine("ENTER THE STAFF id");
                        int idu = Convert.ToInt32(Console.ReadLine());
                        EnterData( idu);
                        break;
                    case "9":
                        Console.WriteLine("PROGRAM ENDED");
                        break;
                    default:
                        Console.WriteLine("INVALID OPTION");
                        break;
                }
            }
            while (select != "9");

        }
        static void EnterData( int? c)
        {
            Console.WriteLine("enter '1' for Teaching Staff\nenter '2' for Administrative Staff\nenter '3' for Support Staff");
            string stype = Console.ReadLine();
            try
            {
                StaffType stafftype = (StaffType)int.Parse(stype) - 1;
                Console.WriteLine("enter the  name");
                string name = Console.ReadLine();
                Console.WriteLine("enter the phone no");
                string phone = Console.ReadLine();
                Console.WriteLine("enter the email id");
                string email = Console.ReadLine();
                string classname, subject;
                if (stafftype == StaffType.TEACHINGSTAFF)
                {
                    Console.WriteLine("enter the classname");
                    classname = Console.ReadLine();
                    Console.WriteLine("enter the subject taught");
                    subject = Console.ReadLine();
                }
                else
                {
                    classname = null;
                    subject = null;
                }
                if (c == null)
                {
                    int id = Operation.IdValue() + 1;
                    Operation.Addata(stafftype, name, phone, email, classname, subject, id);
                }
                else
                {
                    int id = c.GetValueOrDefault();
                    Operation.Update(stafftype, name, phone, email, classname, subject, id);
                }

            }
            catch{
                Console.WriteLine("INVALID OPTION");
            }



        }
    }
}
