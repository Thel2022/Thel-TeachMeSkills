using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace ConsoleAppADONET1
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var sc = new SqlConnection("Server=.; DataBase=SqlPracticeDB; Integrated Security=SSPI; Encrypt=true; TrustServerCertificate=True");

            sc.Open();

            /*var command = new SqlCommand("select avg(person.Age) from persons", sc);
              var avgAge = await command.ExecuteScalarAsync(); */


            var command = new SqlCommand("select person.Name, person.Age, person.AddressId from persons", sc);
            var r = await command.ExecuteReaderAsync();

            var list = new List<Person>();

            while (await r.ReadAsync()) // построчно читаем данные о людях
            {
                var name = await r.GetFieldValueAsync<string>("Name");
                var age = await r.GetFieldValueAsync<int>("age");

                Console.WriteLine($"Name: {name} Age: {age}");

                list.Add(new Person()
                {
                    Name = name,
                    Age = age
                });


                // var command2 = new SqlCommand("select * from persons", sc); доделать, вывод студент с имя, возраст, страна, город.
                
            }

                sc.Close();
        }


        public class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }
    }
}
