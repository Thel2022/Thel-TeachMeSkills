using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1._9
{
    public class Table <T,U,Z>
    {
        public T FirstColumnData { get; set; }
        public U SecondColumnData { get; set; }
        public Z ThirdColumnData { get; set; }

        public Table(T firstColumnData, U secondColumnData, Z thirdColumnData)
        {
            FirstColumnData = firstColumnData;
            SecondColumnData = secondColumnData;
            ThirdColumnData = thirdColumnData;
        }
    }
}
