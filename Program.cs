using System;
using System.IO;

namespace Karakter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Beolvasas("./bin/Debug/net9.0/karakterek.txt");
        }

        static void Beolvasas(string filenev){

            StreamReader sr = new StreamReader(filenev);
            sr.ReadLine();

            while (!sr.EndOfStream)
            {
                string[] sor = sr.ReadLine().Split(';');
                Karakter karakter = new Karakter(sor[0], int.Parse(sor[1]), int.Parse(sor[2]), int.Parse(sor[3]));
                Console.WriteLine(karakter);
            }
        }
    }
}