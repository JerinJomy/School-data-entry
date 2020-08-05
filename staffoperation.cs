using System;
using System.Collections.Generic;
using System.Linq;

namespace Staffs
{
    static class StaffOperation
    {

        private static List<Staff> StaffList = new List<Staff> { };

        public static int IdValue()
        {
            int largest = 0;
            if (StaffList.Count == 0)
            {
                return 0;
            }
            else
            {
                foreach (Staff s in StaffList)
                {
                    if (s.Id > largest)
                        largest = s.Id;
                }
                return largest;
            }

        }
        public static void Addata(StaffType stafftype, string name, string phone, string email, string classname, string subject, int id)
        {
            StaffList.Add(new Staff(stafftype, name, phone, email, classname, subject, id));
        }
        public static void view()
        {
            if (StaffList.Count < 1)
                Console.WriteLine("NO DATA ENTERED");
            else
            {
                foreach (Staff s in StaffList)
                    s.Display();
            }
        }
        public static void Delete(int idd)
        {
            int index = StaffList.FindIndex(s => (s.Id == idd));
            if (index == -1)
                Console.WriteLine("NO STAFF AT THIS ID");
            else
            {
                StaffList.RemoveAt(index);
                Console.WriteLine("entry deleted");
            }
        }
        public static void Update(StaffType stafftype, string name, string phone, string email, string classname, string subject, int id)
        {
            int index = StaffList.FindIndex(s => (s.Id == id));
            if (index == -1)
                Console.WriteLine("NO STAFF AT THIS NAME");
            else
            {
                StaffList[index].EnterData(stafftype, name, phone, email, classname, subject, id);
                Console.WriteLine("ENTRY EDITED");
            }
        }

        public static void ViewOne(int a)
        {
            Staff staff = StaffList.FirstOrDefault(x => x.Id == a);
            if (staff == null)
                Console.WriteLine("NO STAFF WITH THIS NAME");
            else
                staff.Display();
        }

    }

}


