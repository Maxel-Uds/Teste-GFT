using exercicio3.Interface;

namespace exercicio3.Entities
{
    public class COFINS : IImposto
    {
        public double calculaImposto(double amount) {
            if(amount > 13000) {
                return amount * 0.04;
            }
            else {
                return 0;
            }
        }
    }
}