using System;
using System.Collections.Generic;
using System.Text;

namespace WebApplication1
{
    public class JSPerson
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public JSAddress Address { get; set; }
        public JSPerson(string name, int age, string home, string street, string city, string state, string country)
        {
            Name = name;
            Age = age;
            Address = new JSAddress()
            {
                Home = home,
                Street = street,
                City = city,
                State = state,
                Country = country,
            };
        }
    }
}
