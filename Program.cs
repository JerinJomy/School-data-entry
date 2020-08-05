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
                        StaffOperation.EnterData();
                        break;
                    case "2":
                        StaffOperation.view();
                        break;
                    case "3":
                        Console.WriteLine("ENTER THE STAFF id");
                        int idv = Convert.ToInt32(Console.ReadLine());
                        StaffOperation.ViewOne(idv);
                        break;
                    case "4":
                        Console.WriteLine("ENTER THE STAFF id");
                        int idd = Convert.ToInt32(Console.ReadLine());
                        StaffOperation.Delete(idd);
                        break;
                    case "5":
                        Console.WriteLine("ENTER THE STAFF id");
                        int idu = Convert.ToInt32(Console.ReadLine());
                        StaffOperation.UpdateData(idu);
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
    }
}