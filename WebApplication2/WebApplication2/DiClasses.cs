using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2
{
    /*public class A:IA
    {
        private readonly B _b;

        public A (B b)
        {
            _b = b;
        }

        public void Execute() { }
    }
    public interface IA { }

    public class B:IB
    {
        private readonly IC _c;

        public B(IC c)
        {
            _c = c;
        }
       
    }

    public interface IB { }

    public class C:IC
    {
        public void Execute() { }
    }
    public interface IC
    {
        void Execute() { }
    }*/

    public class HomeService : IHomeService
    {

    }
    public interface IHomeService
    {
        public string SaySomething()
        {
            return "Hello Di";
        }
    }
}
