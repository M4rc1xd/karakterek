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

            AtlagSzint(karakterek);

            ErossegSzerintRendezve(karakterek);

            ErosebbE(karakterek, 30);

            karakterStats stats = new karakterStats(karakterek);
            stats.ElegNagySzintuE(8);
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
                    System.Console.Write("\nLegmagasabb életerő: "+item);
                }
            }
        }
    
        static void AtlagSzint(List<Karakter> karakterek){
            int osszeg = 0;
            foreach(var item in karakterek){
                osszeg += item.Szint;
            }
            System.Console.WriteLine("\nÁtlag szint: "+osszeg/karakterek.Count);
        }
    
        static void ErossegSzerintRendezve(List<Karakter> karakterek){
            karakterek.Sort((x, y) => x.Ero.CompareTo(y.Ero));
            System.Console.WriteLine("\nErő szerint rendezve:");
            foreach(var item in karakterek){
                System.Console.WriteLine(item);
            }
        }
    
        static void ErosebbE(List<Karakter> karakterek, int e){
            System.Console.WriteLine("\n"+e+" erosségnél erősebb karakterek:");
            foreach(var item in karakterek){
                if(item.Ero > e){
                    System.Console.WriteLine(item);
                }
            }
        }
    
        

    }
}