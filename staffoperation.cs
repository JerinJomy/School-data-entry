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
                return 1;
            }
            else
            {
                foreach (Staff s in StaffList)
                {
                    if (s.Id > largest)
                    {
                        largest = s.Id;
                    }
                }
                return largest + 1;
            }

        }
        public static void EnterData()
        {
            Console.WriteLine("enter '1' for Teaching Staff\nenter '2' for Administrative Staff\nenter '3' for Support Staff");
            string stype = Console.ReadLine();
            try
            {
                StaffType stafftype = (StaffType)int.Parse(stype);
                Console.WriteLine("enter the  name");
                string name = Console.ReadLine();
                Console.WriteLine("enter the phone no");
                string phone = Console.ReadLine();
                Console.WriteLine("enter the email id");
                string email = Console.ReadLine();
                string classname, subject;
                if (stafftype == StaffType.TEACHINGSTAFF)
                {
                    Console.WriteLine("enter the classname");
                    classname = Console.ReadLine();
                    Console.WriteLine("enter the subject taught");
                    subject = Console.ReadLine();
                    int id = StaffOperation.IdValue();
                    StaffList.Add(new TeachingStaffs(stafftype, name, phone, email, classname, subject, id));
                }
                else if (stafftype == StaffType.ADMINISTRATIVESTAFF)
                {
                    int id = StaffOperation.IdValue();
                    StaffList.Add(new AdministrativeStaff(stafftype, name, phone, email, id));
                }
                else if (stafftype == StaffType.SUPPORTSTAFF)
                {
                    int id = StaffOperation.IdValue();
                    StaffList.Add(new SupportStaffs(stafftype, name, phone, email, id));
                }


            }
            catch
            {
                Console.WriteLine("INVALID OPTION");
            }
        }

        public static void View()
        {
            if (StaffList.Count < 1)
            {
                Console.WriteLine("NO DATA ENTERED");
            }

            else
            {
                foreach (Staff s in StaffList)
                {
                    s.Display();
                }
                    
            }
        }

        public static void ViewOne(int a)
        {
            Staff staff = StaffList.FirstOrDefault(x => x.Id == a);
            if (staff == null)
            {
                Console.WriteLine("NO STAFF WITH THIS ID");
            }
            else
            {
                staff.Display();
            }
        }

        public static void UpdateData(int idu)
        {
            int index = StaffList.FindIndex(s => (s.Id == idu));
            if (index == -1)
            {
                Console.WriteLine("NO STAFF AT THIS ID");
            }
            else
            {
                StaffList[index].Update();
                Console.WriteLine("ENTRY EDITED");
            }
        }
        public static void Delete(int idd)
        {
            int index = StaffList.FindIndex(s => (s.Id == idd));
            if (index == -1)
            {
                Console.WriteLine("NO STAFF AT THIS ID");
            }

            else
            {
                StaffList.RemoveAt(index);
                Console.WriteLine("entry deleted");
            }
        }

    }

}



