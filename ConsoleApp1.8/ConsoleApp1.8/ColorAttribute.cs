using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1._8
{
    class ColorAttribute : Attribute
    {

        public ConsoleColor ObjectColor { get; set; }

        public ColorAttribute(ConsoleColor color)

        {

            ObjectColor = color;

        }



    }

}

