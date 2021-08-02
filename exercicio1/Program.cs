using System;
using System.Collections.Generic;
using exercicio1.Entities;
using System.Linq;

namespace exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Atleta> atletas = new List<Atleta>();

            Console.Write("Quantos atletas competiram? ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++) {
                Console.Write($"Digite o nome do atleta {i}: ");
                string name =Console.ReadLine();
                Console.Write($"Digite o país do atleta {i}: ");
                string country = Console.ReadLine();
                Console.Write($"Digite o resultado (em metros) do atleta {i}: ");
                int distance = int.Parse(Console.ReadLine());

                atletas.Add(new Atleta(name, country, distance));
            }

            List<Atleta> sorted = atletas.OrderBy(x => x.getDistance()).Reverse().ToList();

            Console.WriteLine("Ouro: " + sorted[0]);
            Console.WriteLine("Prata: " + sorted[1]);
            Console.WriteLine("Bonze: " + sorted[2]);
        }
    }
}
