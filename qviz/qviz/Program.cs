using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qviz
{
    internal class Program
    {
        static List<string> kerdeslist = new List<string>();

        static int kerdesbeolvas()
        {
            StreamReader kerdesbe = new StreamReader("Kerdesek.txt");
            while (!kerdesbe.EndOfStream)
            {
                kerdeslist.Add(kerdesbe.ReadLine());
            }
            kerdesbe.Close();
            return kerdeslist.Count();
        }
        static List<string> valaszteklist = new List<string>();

        static int valasztekbeolvas()
        {
            StreamReader valasztekbe = new StreamReader("valasztek.txt");
            while (!valasztekbe.EndOfStream)
            {
                valaszteklist.Add(valasztekbe.ReadLine());
            }
            valasztekbe.Close();
            return valaszteklist.Count();
        }
        static List<string> valaszoklist = new List<string>();

        static int valaszokbeolvas()
        {
            StreamReader valaszokbe = new StreamReader("valaszok.txt");
            while (!valaszokbe.EndOfStream)
            {
                valaszoklist.Add(valaszokbe.ReadLine());
            }
            valaszokbe.Close();
            return valaszoklist.Count();
        }           
        static void Main(string[] args)
        {
            kerdesbeolvas();
            valasztekbeolvas();
            valaszokbeolvas();
            int szamol = 0;
            for (int i = 0; i < kerdeslist.Count(); i++)
            {
                Console.WriteLine(kerdeslist[i]);
                Console.WriteLine(valaszteklist[i]);
                Console.WriteLine("Add meg a válasz betüjelét");
                string valasz = Console.ReadLine();

                while (valasz != "a" && valasz != "b" && valasz != "c" && valasz != "d")
                {
                    Console.WriteLine("a, b, c, vagy d-t írj óda!!");
                    Console.WriteLine(kerdeslist[i]);
                    Console.WriteLine(valaszteklist[i]);
                    Console.WriteLine("Add meg a válasz betüjelét");
                    valasz = Console.ReadLine();
                }
                if (valasz != valaszoklist[i])
                {
                    Console.WriteLine("Rossz a válasz, kezd előről");
                }
            }
             if (szamol == kerdeslist.Count)
            {
                Console.WriteLine("Minden kérdésre helyesen válaszolt, vége a játéknak");
            }
            Console.ReadKey();
        }
    }
}
