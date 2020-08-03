using System;
class Staff
{
  public string Name{get;set;}
  public string StaffType{get;set;}
  public string Phone{get;set;}
  public string Email{get;set;}
  public string ClassName{get;set;}
  public string Subject{get;set;}
  public int Id{get;set;}

 
  public Staff(string i,string a,string b, string c, string d, string e,int u){
    StaffType=i;
    Name=a;
    Phone=b;
    Email=c;
    ClassName=d;
    Subject=e;
    Id=u;
  }
  
  public void display(){
    Console.WriteLine("\nSTAFFID:{0}",Id);
    Console.WriteLine("Staff :{0}",StaffType);
    Console.WriteLine("Name :{0}",Name);
    Console.WriteLine("Phone no :{0}",Phone);
    Console.WriteLine("email id :{0}",Email);
    Console.WriteLine("class name:{0}",ClassName);
    Console.WriteLine("Subject:{0}",Subject);
    
      }
    public void edit(){
    Console.WriteLine("enter the stafftype");
    StaffType=Console.ReadLine();
    Console.WriteLine("enter the  name");
    Name=Console.ReadLine();
    Console.WriteLine("enter the phone no");
    Phone=Console.ReadLine();
    Console.WriteLine("enter the email id");
    Email=Console.ReadLine();
    Console.WriteLine("enter the classname, if non teaching enter nil");
    ClassName=Console.ReadLine();
    Console.WriteLine("enter the subject taught, if non teaching enter nil");
    Subject=Console.ReadLine();
    }
    
  }

