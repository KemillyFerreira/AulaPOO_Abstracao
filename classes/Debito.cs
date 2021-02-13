using Abstração.classes;

namespace Abstração.classes
{
    public class Debito : Cartao
    {
        private float saldo = 600;

        public override string Desconto(int valor)
        {
            throw new System.NotImplementedException();
        }

        public void Pagar(float Valor)
        {
            
        }
    }
}