using System;
using System.Collections.Generic;
namespace staffs
{
       enum stafftype
      {
            TEACHING_STAFF ,
            ADMINISTRATIVE_STAFF,
            SUPPORT_STAFF
      }
    class Program
    {
        static void Main(string[] args)
        {
            List<Staff> lst= new List<Staff>{};
            string select;
            do
            {
              Console.WriteLine("\nENTER '1' FOR DATA ENTRY\nENTER '2' TO VIEW  DETAILS OF ALL STAFF\nENTER '3' TO VIEW STAFF DETAILS IN SPECIFIC\nENTER '4' TO DELETE STAFF DETAILS\nENTER '5' TO UPDATE STAFF DETAILS \nENTER '9' TO EXIT");
              select=Console.ReadLine();
              switch(select){
                case "1":
                     Console.WriteLine("enter '1' for Teaching Staff\nenter '2' for Administrative Staff\nenter '3' for Support Staff");
                     string st=Console.ReadLine();   
                     if(st!= "1"&&st!="2"&&st!="3"){
                        goto default;  
                     }
                     string j=Convert.ToString((stafftype)int.Parse(st)-1);
                     lst.Add(new Staff{});
                     lst[lst.Count-1].stafftype=j;
                     Console.WriteLine("enter the  name");
                     lst[lst.Count-1].name=Console.ReadLine();
                     Console.WriteLine("enter the phone no");
                     lst[lst.Count-1].phone=Console.ReadLine();
                     Console.WriteLine("enter the email id");
                     lst[lst.Count-1].email=Console.ReadLine();
                     if(j=="TEACHING_STAFF")
                     {
                     Console.WriteLine("enter the classname");
                     lst[lst.Count-1].classname=Console.ReadLine();
                     Console.WriteLine("enter the subject taught");
                     lst[lst.Count-1].subject=Console.ReadLine();
                     }
                     else{
                         lst[lst.Count-1].classname="NIL";
                          lst[lst.Count-1].subject="NIL";
                     }
                     
                     break;
                case "2":
                      if(lst.Count==0)
                      Console.WriteLine("NO DATA ENTERED");
                      else{
                            int i=0;
                        foreach(Staff s in lst){
                           i++;   
                          Console.WriteLine("\nSTAFF ID:{0}",i);
                          s.display();
                        }
                        
                      }
                      break;
                case "3":
                      Console.WriteLine("ENTER THE STAFF ID");
                      int a=Convert.ToInt32(Console.ReadLine());
                      if(a>lst.Count)
                      Console.WriteLine("NO STAFF WITH THIS ID");
                      else{
                        Console.WriteLine("\nSTAFFI ID:{0}",a);
                        lst[a-1].display();
                      }
                      break;
                case "4":
                      Console.WriteLine("ENTER THE STAFF ID");
                      int b=Convert.ToInt32(Console.ReadLine());
                      if(b>lst.Count)
                      Console.WriteLine("NO STAFF AT THIS ID");
                      else{
                          lst.RemoveAt(b-1);
                          Console.WriteLine("entry deleted");
                      }
                       break;
                case "5":
                      Console.WriteLine("ENTER THE STAFF ID");
                      int c=Convert.ToInt32(Console.ReadLine());
                       if(c>lst.Count)
                      Console.WriteLine("NO STAFF AT THIS ID");
                      else{
                        lst[c-1].edit();
                          ;
                        Console.WriteLine("ENTRY EDITED");
                      }
                      break;
                case "9":
                      Console.WriteLine("PROGRAM ENDED");
                      break;
                default:
                       Console.WriteLine("INVALID OPTION");
                       break;     
              }
            }
            while(select!="9");

        }
    }
}
