using System;
class Staff
{
  public string name{get;set;}
  public string stafftype{get;set;}
  public string phone{get;set;}
  public string email{get;set;}
  public string classname{get;set;}
  public string subject{get;set;}
  public int id{get;set;}
 
  
  
  public void display(){
    Console.WriteLine("\nSTAFF ID:{0}",id);
    Console.WriteLine("Staff :{0}",stafftype);
    Console.WriteLine("Name :{0}",name);
    Console.WriteLine("Phone no :{0}",phone);
    Console.WriteLine("email id :{0}",email);
    Console.WriteLine("class name:{0}",classname);
    Console.WriteLine("Subject:{0}",subject);
    
      }
    public void edit(){
    Console.WriteLine("enter the stafftype");
    stafftype=Console.ReadLine();
    Console.WriteLine("enter the  name");
    name=Console.ReadLine();
    Console.WriteLine("enter the phone no");
    phone=Console.ReadLine();
    Console.WriteLine("enter the email id");
    email=Console.ReadLine();
    Console.WriteLine("enter the classname, if non teaching enter nil");
    classname=Console.ReadLine();
    Console.WriteLine("enter the subject taught, if non teaching enter nil");
    subject=Console.ReadLine();
    }
    
  }

