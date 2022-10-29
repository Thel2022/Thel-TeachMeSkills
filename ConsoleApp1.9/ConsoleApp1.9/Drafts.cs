using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1._9
{
    class Drafts
    {
        /*
         *  int a = 5;
            Table<int, int, int>[] mytable = new Table<int, int, int>[a];
            mytable[0] = new Table<int, int, int>(0, 1, 2);
            mytable[1] = new Table<int, int, int>(3, 4, 5);
            mytable[2] = new Table<int, int, int>(6, 7, 8);
            mytable[3] = new Table<int, int, int>(9, 10, 11);
            mytable[4] = new Table<int, int, int>(12, 13, 14);
            foreach (Table<int, int, int> i in mytable)
            Console.WriteLine("{0}\t{1}\t{2}", i.FirstColumnData, i.SecondColumnData, i.ThirdColumnData);
         * 
         * public T  FirstColumnData { get; set; }
        public U SecondColumnData { get; set; }
        public Z ThirdColumnData { get; set; }
        public Table(T firstColumnData, U secondColumnData, Z thirdColumnData)
        {
            FirstColumnData = firstColumnData;
            SecondColumnData = secondColumnData;
            ThirdColumnData = thirdColumnData;
        }
         * 
         * MyLinkedList<string> linkedlist = new MyLinkedList<string>();
            linkedlist.Add("Name");
            linkedlist.Add("Age");
            linkedlist.Add("Sex");
            linkedlist.Add("Profession");

            Console.WriteLine("List output");

            foreach (var item in linkedlist)
            {
                Console.WriteLine(item);
            }

            Console.Write("Enter the index of the list item to be removed:");

            int index = Convert.ToInt32(Console.ReadLine());

            linkedlist.RemoveAt(index);

            Console.WriteLine("List output in reverse order (subject to changes):");

            foreach (var t in linkedlist.BackEnumerator())
            {
                Console.WriteLine(t);
            }

            Console.Write("Enter the index of the list item to be added:");

            int index1 = Convert.ToInt32(Console.ReadLine());

            linkedlist.InsertAt("Experience", index1);

            Console.WriteLine("List output (subject to changes):");

            foreach (var item in linkedlist)
            {
                Console.WriteLine(item);
            }




        Console.WriteLine("Input number");
            var input = Console.ReadLine();
            try
            {
                ProcessInput(input);
            }
            catch (InvalidInputExeption(e))
            {
                Console.WriteLine($"Invalid input: {e.Message}");

                throw;

            }
        }
        public static void ProcessInput (string input)
        {
            var isNumber = int.TryParse(input, out var number);
                // _ если переменная не нужна
                throw new InvalidInputExeption();
        }
class InvalidInputExeption : Exception
    {
        public void InvalidInputExeption(string massage) : base(massage);
    }


        using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Xml.Serialization;
using Newtonsoft.Json;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string str = "Some text";

            Stream stream = new MemoryStream();
            byte[] sttob = Encoding.Unicode.GetBytes(str);
            stream.Write(sttob);
            stream.Flush();
            stream.Seek(0, SeekOrigin.Begin);

            var buffer = new byte[stream.Length];
            stream.Read(buffer, 0, (int)stream.Length);
            var sqtt = Encoding.Unicode.GetString(buffer);
            Console.WriteLine(sqtt);

            stream.Close();
            */
        /*
        string str = "Some text";

        Stream stream = new MemoryStream();
        byte[] sttob = Encoding.Unicode.GetBytes(str);
        stream.Write(sttob);
        stream.Flush();
        stream.Seek(0, SeekOrigin.Begin);

        var buffer = new byte[1024];
        var bufferread = 1;
        var sqtt = "";

        while (bufferread > 1)
        {
            bufferread = stream.Read(buffer, 0, 1024);
            sqtt = sqtt + Encoding.Unicode.GetString(buffer);
        }

        Console.WriteLine(sqtt);
        stream.Close();
        */

        /*
        string str = "Some text";

        Stream stream = new MemoryStream();
        var streamwriter = new StreamWriter(stream); // new BinaryWriter(stream);

        streamwriter.Write(str);
        streamwriter.Flush();

        stream.Seek(0, SeekOrigin.Begin);

        var streamreader = new StreamReader(stream);
        var str1 = streamreader.ReadToEnd();

        Console.WriteLine(str1);
        stream.Close();
        streamreader.Close();
        streamwriter.Close();
        */

        /*
        string str = "Some text";

        var obj = new Person()
        {
            Age = 12
        };

        FileStream stream = File.Open("data.bin", FileMode.OpenOrCreate);

        var streamwriter = new StreamWriter(stream);
        streamwriter.Write(obj);
        streamwriter.Flush();

        stream.Seek(0, SeekOrigin.Begin);

        var streamreader = new StreamReader(stream);
        var str1 = streamreader.ReadToEnd();


        Console.WriteLine(str1);
        stream.Close();
        streamreader.Close();
        streamwriter.Close();


    }
}

public class Person
{
    public int Age { get; set; }
    private string _name;
    public Person()
    {
        _name = "Dick";
    }
    public override string ToString()
    {
        return base.ToString();
    }
}
        */

        /*
        string str = "Some text";

        var obj = new Person()
        {
            Age = 12
        };

        FileStream stream = File.Open("person.txt", FileMode.OpenOrCreate);

        BinaryFormatter bf = new BinaryFormatter();
        bf.Serialize(stream, obj);

        stream.Seek(0, SeekOrigin.Begin);

        var personfromfile = bf.Deserialize(stream);

        Console.WriteLine(personfromfile);
        stream.Close();




        var streamwriter = new StreamWriter(stream);
        streamwriter.Write(obj);
        streamwriter.Flush();



        var streamreader = new StreamReader(stream);
        var str1 = streamreader.ReadToEnd();


        Console.WriteLine(str1);
        stream.Close();
        streamreader.Close();
        streamwriter.Close();


    }
}
[Serializable]
public class Person
{
    public int Age { get; set; }
    private string _name;
    public Person()
    {
        _name = "Dick";
    }
    public override string ToString()
    {
        return &
    }
}
        */

        /*
        string str = "Some text";

        var obj = new Person()
        {
            Age = 12
        };

        FileStream stream = File.Open("person.txt", FileMode.OpenOrCreate);

        XmlSerializer xs = new XmlSerializer(typeof(Person));

        xs.Serialize(stream, obj);

        stream.Seek(0, SeekOrigin.Begin);



        var streamwriter = new StreamWriter(stream);
        streamwriter.Write(obj);
        streamwriter.Flush();



        var streamreader = new StreamReader(stream);
        var str1 = streamreader.ReadToEnd();

        /*stream.Seek(0, SeekOrigin.Begin);
        var des = (Person)xs.Deserialize(stream);
        Console.WriteLine(des);
        */


        /*
        Console.WriteLine(str1); //
        stream.Close();
        streamreader.Close(); //
        streamwriter.Close(); //


    }
}

public class Person
{
    public int Age { get; set; }
    private string _name;
    public Person()
    {
        _name = "Dick";
    }
    public override string ToString()
    {
        return $"{Age} {_name}";
    }
}
        */
        /*
        var obj = new Person()
        {
            Age = 12
        };

        FileStream stream = File.Open("person.json", FileMode.OpenOrCreate);
        var sw = new StreamWriter(stream);

        JsonSerializer js = new JsonSerializer();
        js.Serialize(sw, obj);
            sw.Flush();

            var jsstring = JsonConvert.SerializeObject(obj);

        stream.Seek(0, SeekOrigin.Begin);

            var streamreader = new StreamReader(stream);
        var str1 = streamreader.ReadToEnd();
        stream.Seek(0, SeekOrigin.Begin);
            stream.Close();
        }
    public class Person
    {
        public int Age { get; set; }
        private string _name;
        public Person()
        {
            _name = "Dick";
        }
        public override string ToString()
        {
            return $"{Age} {_name}";
        }
    }
}


        */
    }
}
