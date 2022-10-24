using System;
using System.IO;
using Newtonsoft.Json;

namespace WebApplication1
{
    public class JSTable
    {
        public JSTable() { }

        public JSPerson Json()
        {

            string fileName = "Data.json";
            string jsonString = File.ReadAllText(fileName);
            JSPerson person = JsonConvert.DeserializeObject<JSPerson>(jsonString)!;
            return person;

        }
           
    }
}
