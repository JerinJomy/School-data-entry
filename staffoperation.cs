using System;
using System.Collections.Generic;
using System.Linq;

namespace Staffs
{
    static class Operation
    {

        private static List<Staff> lst = new List<Staff> { };

        public static int IdValue()
        {
            int largest = 0;
            if (lst.Count == 0)
                return 0;
            else
            {
                foreach (Staff s in lst)
                {
                    if (s.Id > largest)
                        largest = s.Id;
                }
                return largest;
            }

        }
        public static void Addata(StaffType stafftype, string name, string phone, string email, string classname, string subject, int id)
        {
            lst.Add(new Staff(stafftype, name, phone, email, classname, subject, id));
        }
        public static void view()
        {
            if (lst.Count < 1)
                Console.WriteLine("NO DATA ENTERED");
            else
            {
                foreach (Staff s in lst)
                    s.Display();
            }
        }
        public static void Delete(int b)
        {
            int index = lst.FindIndex(s => (s.Id == b));
            if (index == -1)
                Console.WriteLine("NO STAFF AT THIS ID");
            else
            {
                lst.RemoveAt(index);
                Console.WriteLine("entry deleted");
            }
        }
        public static void Update(StaffType stafftype, string name, string phone, string email, string classname, string subject, int id)
        {
            int index = lst.FindIndex(s => (s.Id == id));
            if (index == -1)
                Console.WriteLine("NO STAFF AT THIS NAME");
            else
            {
                lst[index].EnterData(stafftype, name, phone, email, classname, subject, id);
                Console.WriteLine("ENTRY EDITED");
            }
        }

        public static void ViewOne(int a)
        {
            Staff staff = lst.FirstOrDefault(x => x.Id == a);
            if (staff == null)
                Console.WriteLine("NO STAFF WITH THIS NAME");
            else
                staff.Display();
        }

    }

}


