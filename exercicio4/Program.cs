using System;
using exercicio4.Entities;

namespace exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Multiplicando: ");
            int multi = int.Parse(Console.ReadLine());
            Console.Write("Início do intervalo: ");
            int inicio = int.Parse(Console.ReadLine());
            Console.Write("Fim do intervalo: ");
            int fim = int.Parse(Console.ReadLine());

            Controle control = new Controle(multi, inicio, fim);
            if(control.Verifica() == 0) {
                control.Calcula();
            }
        }
    }
}
