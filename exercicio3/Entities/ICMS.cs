using exercicio3.Interface;

namespace exercicio3.Entities
{
    public class ICMS : IImposto
    {
        public double calculaImposto(double amount) {
            return amount * 0.27;
        }
    }
}