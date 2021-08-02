using exercicio3.Interface;

namespace exercicio3.Entities
{
    public class IPI : IImposto
    {
        public double calculaImposto(double amount) {
            if(amount < 25000) {
                return amount * 0.05;
            }
            else {
                return amount * 0.11;
            }
        }
    }
}