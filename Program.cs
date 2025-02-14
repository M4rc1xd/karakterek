using System;
using System.IO;

namespace Karakter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Karakter> karakterek = [];

            Beolvasas("./bin/Debug/net9.0/karakterek.txt", karakterek);

            foreach(var item in karakterek){
                Console.WriteLine(item);
            }

            LegmagasabbEletero(karakterek);
        }

        static void Beolvasas(string filenev, List<Karakter> karakterek){

            StreamReader sr = new StreamReader(filenev);
            sr.ReadLine();

            while (!sr.EndOfStream)
            {
                string[] sor = sr.ReadLine().Split(';');
                karakterek.Add(new Karakter(sor[0], Convert.ToInt16(sor[1]), Convert.ToInt16(sor[2]), Convert.ToInt16(sor[3])));
            }
        }

        static void LegmagasabbEletero(List<Karakter> karakterek){
            int max = 0;
            foreach(var item in karakterek){
                if(item.Eletero > max){
                    max = item.Eletero;
                }
            }

            foreach(var item in karakterek){
                if(item.Eletero == max){
                    System.Console.WriteLine();
                    System.Console.Write("Legmagasabb életerő: "+item);
                }
            }
        }
    }
}