using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Versenyzők
{
    class Program
    {
        static List<lista> pilotak = new List<lista>();
        static void Main(string[] args)
        {
            MasodikFeladat();
            HarmadikFeladat();
            NegyedikFeladat();
            ÖtödikFeladat();
            HatodikFeladat();
            HetedikFeladat();

            Console.ReadKey();
        }

        private static void HetedikFeladat()
        {
            Console.WriteLine("7. feladat: ");
        }

        private static void HatodikFeladat()
        {
            Console.WriteLine("6. feladat: ");
        }

        private static void ÖtödikFeladat()
        {
            Console.WriteLine("5. feladat: ");
        }

        private static void NegyedikFeladat()
        {
            Console.WriteLine("4. feladat: {0}", pilotak.Last().Nev);
        }

        private static void HarmadikFeladat()
        {
            Console.WriteLine("3. feladat: {0}", pilotak.Count());
        }

        private static void MasodikFeladat()
        {
            Console.WriteLine("2. feladat: ");
            StreamReader be = new StreamReader("pilotak.csv");
            be.ReadLine();
            while (!be.EndOfStream)
            {
                pilotak.Add(new lista(be.ReadLine()));
            }
            be.Close();
        }
    }
}
