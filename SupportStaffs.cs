using System;
namespace Staffs
{
    class SupportStaffs : Staff
    {
        public SupportStaffs(StaffType staffType, string name, string phone, string email, int id)
        {
            StaffType = staffType;
            Name = name;
            Phone = phone;
            Email = email;
            Id = id;
        }
        public override void Display()
        {
            Console.WriteLine("\nSTAFFID:{0}", Id);
            Console.WriteLine("Staff :{0}", StaffType);
            Console.WriteLine("Name :{0}", Name);
            Console.WriteLine("Phone no :{0}", Phone);
            Console.WriteLine("email id :{0}", Email);
        }

        public override void Update()
        {
            Console.WriteLine("enter the  name");
            Name = Console.ReadLine();
            Console.WriteLine("enter the phone no");
            Phone = Console.ReadLine();
            Console.WriteLine("enter the email id");
            Email = Console.ReadLine();
        }
    }
}