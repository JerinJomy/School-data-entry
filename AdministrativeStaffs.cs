using System;
namespace Staffs
{
    class AdministrativeStaff : Staffs
    {

        public AdministrativeStaff(StaffType staffType, string name, string phone, string email, int id) : base(staffType, name, phone, email, id)
        {
        }
        public override void Display()
        {
            base.Display();
        }
        public override void Update()
        {
            base.Display();
        }
    }
}