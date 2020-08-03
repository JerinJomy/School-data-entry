using System;
using System.Collections.Generic;
namespace staffs
{
      enum stafftype
      {
            TEACHINGSTAFF ,
            ADMINISTRATIVESTAFF,
            SUPPORTSTAFF
      }
    class Program
    {
        static void Main(string[] args)
        {
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
                     Console.WriteLine("enter the  name");
                     string z=Console.ReadLine();
                     Console.WriteLine("enter the phone no");
                     string y=Console.ReadLine();
                     Console.WriteLine("enter the email id");
                     string x=Console.ReadLine();
                     string w,v;
                     if(j=="TEACHINGSTAFF"){
                       Console.WriteLine("enter the classname");
                        w=Console.ReadLine();
                       Console.WriteLine("enter the subject taught");
                        v=Console.ReadLine();
                     }
                     else{
                        v="NIL";
                        w="NIL";
                     }
                     int u=Extra.idvalue()+1;
                      Extra.Addata(j,z,y,x,w,v,u);
                     break;
                case "2":
                      Extra.view();
                      break;
                case "3":
                      Console.WriteLine("ENTER THE STAFF id");
                      int a=Convert.ToInt32(Console.ReadLine());
                      Extra.viewone(a);
                      break;
                case "4":
                      Console.WriteLine("ENTER THE STAFF id");
                     int b=Convert.ToInt32(Console.ReadLine());
                      Extra.newdelete(b);
                       break;
                case "5":
                      Console.WriteLine("ENTER THE STAFF id");
                      int c=Convert.ToInt32(Console.ReadLine());
                       Extra.newedit(c);
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
