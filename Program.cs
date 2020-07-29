using System;
using System.Collections.Generic;
namespace staffs
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Staff> lst= new List<Staff>{};
            int select;
            do
            {
              Console.WriteLine("\nENTER '1' FOR DATA ENTRY\nENTER '2' TO VIEW  DETAILS OF ALL STAFF\nENTER '3' TO VIEW STAFF DETAILS IN SPECIFIC\nENTER '4' TO DELETE STAFF DETAILS\nENTER '5' TO UPDATE STAFF DETAILS \nENTER '9' TO EXIT");
              select=Convert.ToInt32(Console.ReadLine());
              switch(select){
                case 1:
                     lst.Add(new Staff{});
                     Console.WriteLine("enter the stafftype");
                     lst[lst.Count-1].stafftype=Console.ReadLine();
                     Console.WriteLine("enter the  name");
                     lst[lst.Count-1].name=Console.ReadLine();
                     Console.WriteLine("enter the phone no");
                     lst[lst.Count-1].phone=Console.ReadLine();
                     Console.WriteLine("enter the email id");
                     lst[lst.Count-1].email=Console.ReadLine();
                     Console.WriteLine("enter the classname, if non teaching enter nil");
                     lst[lst.Count-1].classname=Console.ReadLine();
                     Console.WriteLine("enter the subject taught, if non teaching enter nil");
                     lst[lst.Count-1].subject=Console.ReadLine();
                     lst[lst.Count-1].id=lst.Count;
                     break;
                case 2:
                      if(lst.Count==0)
                      Console.WriteLine("NO DATA ENTERED");
                      else{
                        foreach(Staff s in lst)
                        s.display();
                      }
                      break;
                case 3:
                      Console.WriteLine("ENTER THE STAFF ID");
                      int a=Convert.ToInt32(Console.ReadLine());
                      if(a>lst.Count)
                      Console.WriteLine("NO STAFF WITH THIS ID");
                      else
                      lst[a-1].display();
                      break;
                case 4:
                      Console.WriteLine("ENTER THE STAFF ID");
                      int b=Convert.ToInt32(Console.ReadLine());
                      if(b>lst.Count)
                      Console.WriteLine("NO STAFF AT THIS ID");
                      else{
                          lst.RemoveAt(b-1);
                          Console.WriteLine("entry deleted");
                      }
                       break;
                case 5:
                      Console.WriteLine("ENTER THE STAFF ID");
                      int c=Convert.ToInt32(Console.ReadLine());
                       if(c>lst.Count)
                      Console.WriteLine("NO STAFF AT THIS ID");
                      else{
                        lst[c-1].edit();
                        lst[c-1].id=c;
                        Console.WriteLine("ENTRY EDITED");
                      }
                      break;
                case 9:
                      Console.WriteLine("PROGRAM ENDED");
                      break;
                default:
                       Console.WriteLine("INVALID OPTION");
                       break;     
              }
            }
            while(select!=9);

        }
    }
}
