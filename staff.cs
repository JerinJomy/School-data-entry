using System;

namespace Staffs
{
    abstract class Staff
    {

        public string Name { get; set; }
        public StaffType StaffType { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int Id { get; set; }




        abstract public void Display();
        abstract public void Update();

    }


}

