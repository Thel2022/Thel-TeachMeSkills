using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1._8
{
    interface IPrinter
    {

        void MenuAndPrint();
        string ShapeSelection();
        int EnterSize();
        char EnterSymbol();
        int EnterX();
        int EnterY();
        void Reverse();
        public Shape ShapeCreator(string name, int size, char symbol, int x, int y);

    }
}
