using System;

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

            if(multi > 1000) {
                Console.WriteLine("O multiplicando não pode ser maior que mil");
            }
            else if((inicio < 0 || inicio > 1000) || (fim < 0 || fim > 1000)) {
                Console.WriteLine("início ou fim, não podem ser números negativos e não podem ser maiores de mil");
            }
            else if(fim - inicio >= 10) {
                Console.WriteLine("O intervalo entre início e fim não pode ser maiior que dez");
            }
            else if(fim < inicio) {
                Console.WriteLine("O início do intervalo deve ser menor que o fim");
            }
            else {
                for(int i = inicio; i <= fim; i++) {
                    Console.WriteLine($"{multi} X {i} = {(i * multi)}");
                }
            }
        }
    }
}
