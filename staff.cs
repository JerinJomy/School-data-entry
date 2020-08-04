using System;

namespace Staffs
{
    class Staff
    {

        public string Name { get; set; }
        public StaffType StaffType { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string ClassName { get; set; }
        public string Subject { get; set; }
        public int Id { get; set; }


        public Staff(StaffType staffType, string name, string phone, string email, string classname, string subject, int id)
        {
            StaffType = staffType;
            Name = name;
            Phone = phone;
            Email = email;
            ClassName = classname;
            Subject = subject;
            Id = id;
        }

        public void Display()
        {
            Console.WriteLine("\nSTAFFID:{0}", Id);
            Console.WriteLine("Staff :{0}", StaffType);
            Console.WriteLine("Name :{0}", Name);
            Console.WriteLine("Phone no :{0}", Phone);
            Console.WriteLine("email id :{0}", Email);
            Console.WriteLine("class name:{0}", ClassName);
            Console.WriteLine("Subject:{0}", Subject);

        }
        public void EnterData(StaffType j, string z, string y, string x, string w, string v, int u)
        {

            StaffType = j;
            Name = z;
            Phone = y;
            Email = x;
            ClassName = w;
            Subject = v;
            Id = u;
        }

    }


}

