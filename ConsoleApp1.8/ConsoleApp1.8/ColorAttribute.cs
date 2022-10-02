using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1._8
{
    [AttributeUsage(AttributeTargets.Constructor)]
    class ColorAttribute : Attribute
    {
        public string Name { get; }
        public ColorAttribute () { }
        public ColorAttribute(string name) => Name = name;
    }
}
