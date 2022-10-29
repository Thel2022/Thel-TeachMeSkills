using System;
using System.IO;
using Newtonsoft.Json;


namespace ConsoleApp1._9
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            Json();
            AddFile();
            Repeat();

            static void Json()
            {
                Console.WriteLine("Enter name of json file (like 'Data.json or Data1.json')");
                try
                {
                    string fileName = Console.ReadLine();
                    string jsonString = File.ReadAllText(fileName);
                    JSPerson person = JsonConvert.DeserializeObject<JSPerson>(jsonString)!;
                    Console.WriteLine("\n* * * * *\n");
                    Console.WriteLine($"Name: {person.Name}");
                    Console.WriteLine($"Age: {person.Age}");
                    Console.WriteLine($"Adress: {person.Address.Home},{person.Address.Street},{person.Address.City},{person.Address.State},{person.Address.Country}");
                }
                catch
                {
                    Console.WriteLine("Incorrect file!");
                }
            }

            static void AddFile()
            {
                Console.WriteLine("\n* * * * *\n");
                Console.WriteLine("Let's add some new file!");
                Console.WriteLine("Enter name:");
                string name = Console.ReadLine();
                Console.WriteLine("Enter age:");
                int age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter country:");
                string country = Console.ReadLine();
                Console.WriteLine("Enter state:");
                string state = Console.ReadLine();
                Console.WriteLine("Enter city:");
                string city = Console.ReadLine();
                Console.WriteLine("Enter street:");
                string street = Console.ReadLine();
                Console.WriteLine("Enter home:");
                string home = Console.ReadLine();

                var person = new JSPerson(name,age,home,street,city,state,country);
                FileStream fileStream = File.Create("Data2.json", (int)FileMode.OpenOrCreate);
                var sw = new StreamWriter(fileStream);
                JsonSerializer js = new JsonSerializer();
                js.Serialize(sw, person);
                sw.Flush();
                fileStream.Close();
                Console.WriteLine("Now we have Data2.json file!");
            }

            static void Repeat()
            {

                Console.WriteLine("\n* * * * *\n");
                Console.WriteLine("Do you want to continue (yes/no)?");
                string choice2 = Console.ReadLine();
                if (choice2 == "yes")
                {
                    Json();
                    Repeat();

                }
                else if (choice2 == "no")
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Something is wrong! Try again!");
                    Repeat();
                }



            }
        }
    }
}
