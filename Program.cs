using System;
using System.Collections.Generic;
namespace Staffs
{
    class Program
    {
        static void Main(string[] args)
        {
            string select; /*small main function*/
            do
            {
                Console.WriteLine("\nENTER '1' FOR DATA ENTRY\nENTER '2' TO VIEW  DETAILS OF ALL STAFF\nENTER '3' TO VIEW STAFF DETAILS IN SPECIFIC\nENTER '4' TO DELETE STAFF DETAILS\nENTER '5' TO UPDATE STAFF DETAILS \nENTER '9' TO EXIT");
                select = Console.ReadLine();
                switch (select)
                {
                    case "1":
                        Console.WriteLine("enter '1' for Teaching Staff\nenter '2' for Administrative Staff\nenter '3' for Support Staff");
                        string st = Console.ReadLine();
                        if (st != "1" && st != "2" && st != "3")
                        {
                            goto default;
                        }
                        string j = Convert.ToString((StaffType)int.Parse(st) - 1);
                        Console.WriteLine("enter the  name");
                        string z = Console.ReadLine();
                        Console.WriteLine("enter the phone no");
                        string y = Console.ReadLine();
                        Console.WriteLine("enter the email id");
                        string x = Console.ReadLine();
                        string w, v;
                        if (j == "TEACHINGSTAFF")
                        {
                            Console.WriteLine("enter the classname");
                            w = Console.ReadLine();
                            Console.WriteLine("enter the subject taught");
                            v = Console.ReadLine();
                        }
                        else
                        {
                            v = "NIL";
                            w = "NIL";
                        }
                        int u = Operations.GetId() + 1;
                        Operations.Addata(j, z, y, x, w, v, u);
                        break;
                    case "2":
                        Operations.view();
                        break;
                    case "3":
                        Console.WriteLine("ENTER THE STAFF id");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Operations.viewone(a);
                        break;
                    case "4":
                        Console.WriteLine("ENTER THE STAFF id");
                        int b = Convert.ToInt32(Console.ReadLine());
                        Operations.newdelete(b);
                        break;
                    case "5":
                        Console.WriteLine("ENTER THE STAFF id");
                        int c = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("enter '1' for Teaching Staff\nenter '2' for Administrative Staff\nenter '3' for Support Staff");
                        string st1 = Console.ReadLine();
                        if (st1 != "1" && st1 != "2" && st1 != "3")
                        {
                            goto default;
                        }
                        string j1 = Convert.ToString((StaffType)int.Parse(st1) - 1);
                        Console.WriteLine("enter the  name");
                        string z1 = Console.ReadLine();
                        Console.WriteLine("enter the phone no");
                        string y1 = Console.ReadLine();
                        Console.WriteLine("enter the email id");
                        string x1 = Console.ReadLine();
                        string w1, v1;
                        if (j1 == "TEACHINGSTAFF")
                        {
                            Console.WriteLine("enter the classname");
                            w1 = Console.ReadLine();
                            Console.WriteLine("enter the subject taught");
                            v1 = Console.ReadLine();
                        }
                        else
                        {
                            v1 = "NIL";
                            w1 = "NIL";
                        }
                        int u1 = c;
                        Operations.newedit(c, j1, z1, y1, x1, w1, v1, u1);
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
