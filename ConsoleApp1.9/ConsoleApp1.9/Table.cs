using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1._9
{
    public class Table <T,U,Z> // don't work
    {
        T obj1 { get; set; }
        U obj2 { get; set; }
        Z obj3 { get; set; }

        List<T> firstColumnList;
        List<U> secondColumnList;
        List<Z> thirdColumnList;

        public Table(T obj1, U obj2, Z obj3)
        {
            this.obj1 = obj1;
            this.obj2 = obj2;
            this.obj3 = obj3;
        }

    public static void ReadData() { }

         public void CreateString(T obj1, U obj2, Z obj3)
        {
            Console.WriteLine("{T}\t{1}\t{2}", obj1, obj2, obj3);
        }
    }
  
   
}
