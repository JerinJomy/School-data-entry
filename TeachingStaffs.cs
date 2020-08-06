using System;
namespace Staffs
{
    class TeachingStaffs : Staffs
    {
        public string ClassName { get; set; }
        public string Subject { get; set; }

        public TeachingStaffs(StaffType staffType, string name, string phone, string email, string classname, string subject, int id) : base(staffType, name, phone, email, id)
        {
            ClassName = classname;
            Subject = subject;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("class name:{0}", ClassName);
            Console.WriteLine("Subject:{0}", Subject);
        }
        public override void Update()
        {
            base.Update();
            Console.WriteLine("enter the class name");
            ClassName = Console.ReadLine();
            Console.WriteLine("enter the Subject");
            Subject = Console.ReadLine();

        }
    }
}