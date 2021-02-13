using System;

namespace Abstração.classes
{
    public abstract class Pagamento
    {
        //atributos
        private DateTime data;

        protected float valor;

        //métodos
        public string Cancelar()
        {
            return "";
        }

        //esse método será obrigatório
        public abstract string Desconto(int valor);
    }
}
