using System;

namespace exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {

            Random num = new Random();
            int randomNum = num.Next(0, 7);

            Console.Write("Digite um número: ");
            int n = int.Parse(Console.ReadLine());

            while(!(n == randomNum)) {
                Console.Write("Você errou! Tente de novo: ");
                n = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Parabéns!! Você acertou!");
        }
    }
}
