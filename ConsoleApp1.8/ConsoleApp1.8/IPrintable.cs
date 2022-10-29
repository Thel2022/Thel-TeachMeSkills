using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1._8
{
    internal interface IPrintable
    {
        public void Print();

        //public event Action<string> RepeatEvent;

        /*public event EventHandler <RepeatEventArgs> RepeatEvent;

        public void Reapit() { }

        protected virtual void OnRepeatEvent()
        {
           
        }

        /* https://professorweb.ru/my/csharp/charp_theory/level10/10_9.php
         * https://learn.microsoft.com/en-us/dotnet/api/system.eventargs?view=net-6.0
         */
    }
}
