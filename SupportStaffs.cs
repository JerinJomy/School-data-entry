using System;
namespace Staffs
{
    class SupportStaffs : Staffs
    {
        public SupportStaffs(StaffType staffType, string name, string phone, string email, int id) : base(staffType, name, phone, email, id)
        {
        }
        public override void Display()
        {
            base.Display();
        }

        public override void Update()
        {
            base.Update();
        }
    }
}