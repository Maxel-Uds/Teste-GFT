using System;

namespace exercicio4.Entities
{
    public class Controle
    {
        public int Multi { get; set; }
        public int Inicio { get; set; }
        public int Fim { get; set; }

        public Controle(int multi, int inicio, int fim) {
            Multi = multi;
            Inicio = inicio;
            Fim = fim;
        }

        public int Verifica() {
            if(Multi > 1000) {
                Console.WriteLine("O multiplicando não pode ser maior que mil");
                return 1;
            }
            else if((Inicio < 0 || Inicio > 1000) || (Fim < 0 || Fim > 1000)) {
                Console.WriteLine("início ou fim, não podem ser números negativos e não podem ser maiores de mil");
                return 1;
            }
            else if(Fim - Inicio >= 10) {
                Console.WriteLine("O intervalo entre início e fim não pode ser maiior que dez");
                return 1;
            }
            else if(Fim < Inicio) {
                Console.WriteLine("O início do intervalo deve ser menor que o fim");
                return 1;
            }
            else {
                return 0;
            }
        }

        public void Calcula() {
            for(int i = Inicio; i <= Fim; i++) {
                Console.WriteLine($"{Multi} X {i} = {(i * Multi)}");
            }
        }
    }
}