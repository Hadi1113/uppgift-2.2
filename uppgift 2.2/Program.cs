using System;

namespace Uppgift2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur långt hoppade Elin? Svara i meter.");
            double elinHögt = double.Parse (Console.ReadLine());
            Console.WriteLine("Hur långt hoppade Alma? Svara i meter.");
            double almaHögt = double.Parse (Console.ReadLine());

            double skillnad = elinHögt - almaHögt;
            Console.WriteLine($"Elin hoppade {skillnad} meter längre än Alma.");
        }
    }
}
                

        