using Abstração.classes;

namespace Abstração.classes
{
    public abstract class Cartao : Pagamento
    {
        public string bandeira;
        public string numero;
        public string titular;
        public string cvv;

        public string SalvarCartao()
        {
            return "";
        }
    }
}