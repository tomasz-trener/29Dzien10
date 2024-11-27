using P04Zawodnicy.Shared.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02Wyszukiwarka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IManagerZawodnikow mz = new ManagerZawodnikowLINQ();
            var zawodnicy = mz.PodajZawodnikowFiltr("ma");

            foreach (var z in zawodnicy)
            {
                Console.WriteLine(z.ImieNazwisko);
            }
            Console.ReadKey();
        }
    }
}
