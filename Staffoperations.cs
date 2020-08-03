using System;
using System.Collections.Generic;
 static class Operations
     {
       
       private static List<Staff> lst= new List<Staff>{};
  
      public static int idvalue(){
        int x=0;
        if(lst.Count==0)
        return 0;
        else{
            foreach(Staff s in lst)
         {
            if(s.Id>x)
            x=s.Id;
         }
         return x;
        }
         
      }
       public static void Addata(string j,string z,string y,string x,string w,string v,int u)
       {
         lst.Add(new Staff(j,z,y,x,w,v,u));
         }
        public static void view()
        {
          if(lst.Count<1)
          Console.WriteLine("NO DATA ENTERED");
          else{
            foreach(Staff x in lst )
            x.display();
          }
        }
        public static void newdelete(int b){
          int index=lst.FindIndex(s=> (s.Id==b));
          if(index==-1)
          Console.WriteLine("NO STAFF AT THIS ID");
          else{
            lst.RemoveAt(index);
            Console.WriteLine("entry deleted");
              }
        }
        public static void newedit(int c,string j,string z,string y,string x,string w,string v,int u){
          int index=lst.FindIndex(s=> (s.Id==c));
          if(index==-1)
          Console.WriteLine("NO STAFF AT THIS NAME");
           else{
           lst[index].newdata(j,z,y,x,w,v,u);
           Console.WriteLine("ENTRY EDITED");
           }
        }

        public static void viewone(int a){
          int index=lst.FindIndex(x=> x.Id==a);
         if(index==-1)
         Console.WriteLine("NO STAFF WITH THIS NAME");
         else
         lst[index].display();
           }
           
     }
     
