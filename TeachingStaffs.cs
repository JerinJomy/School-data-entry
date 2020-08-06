using System;
namespace Staffs
{
    class TeachingStaffs : Staff
    {
        public string ClassName { get; set; }
        public string Subject { get; set; }

        public TeachingStaffs(StaffType staffType, string name, string phone, string email, string classname, string subject, int id)
        {
            StaffType = staffType;
            Name = name;
            Phone = phone;
            Email = email;
            ClassName = classname;
            Subject = subject;
            Id = id;
        }

        public override void Display()
        {
            Console.WriteLine("\nSTAFFID:{0}", Id);
            Console.WriteLine("Staff :{0}", StaffType);
            Console.WriteLine("Name :{0}", Name);
            Console.WriteLine("Phone no :{0}", Phone);
            Console.WriteLine("email id :{0}", Email);
            Console.WriteLine("class name:{0}", ClassName != null ? ClassName : "Nil");
            Console.WriteLine("Subject:{0}", Subject != null ? ClassName : "Nil");
        }
        public override void Update()
        {
            Console.WriteLine("enter the  name");
            Name = Console.ReadLine();
            Console.WriteLine("enter the phone no");
            Phone = Console.ReadLine();
            Console.WriteLine("enter the email id");
            Email = Console.ReadLine();
            Console.WriteLine("enter the class name");
            ClassName = Console.ReadLine();
            Console.WriteLine("enter the Subject");
            Subject = Console.ReadLine();

        }
    }
}