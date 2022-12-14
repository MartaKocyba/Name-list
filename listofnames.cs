using System;
using System.Xml.Linq;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = System.IO.File.ReadAllText("./../../../lista imion.txt");
            string[] arrtext = text.Split("\n");
            foreach (var name in arrtext)
            {
                if (name.Contains("Anna "))
                {
                    Console.WriteLine(name);
                }
            }
            Console.WriteLine("==========");
            Console.WriteLine("246 imię i nazwisko to: " + arrtext[246]);



            Console.ReadKey();
        }
    }
}