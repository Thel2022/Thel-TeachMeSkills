using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1._8
{
    interface IPrintable
    {

        void MenuAndPrint();
        string ShapeSelection();
        int EnterSize();
        char EnterSymbol();
        int EnterX();
        int EnterY();
        void Reverse();

    }
}
