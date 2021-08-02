using System;
using exercicio3.Entities;

namespace exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICMS icms = new ICMS();
            IPI ipi = new IPI();
            COFINS cof = new COFINS();

            Console.Write("Digite o valor da quantia: ");
            double amount = double.Parse(Console.ReadLine());

            Console.WriteLine($"ICMS: {icms.calculaImposto(amount).ToString("F2")}");
            Console.WriteLine($"IPI: {ipi.calculaImposto(amount).ToString("F2")}");
            Console.WriteLine($"COFINS: {cof.calculaImposto(amount).ToString("F2")}");

            Console.WriteLine($"Total a pagar: {(icms.calculaImposto(amount) + ipi.calculaImposto(amount) + cof.calculaImposto(amount) + amount).ToString("F2")}");
        }
    }
}
