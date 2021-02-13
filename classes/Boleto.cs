using System;
using Abstração.classes;

namespace Abstração
{
    public class Boleto : Pagamento
    {
        private string codigoDeBarras = "123456.1231231231231.1231231231.123123123";
        public string CodigoDeBarras
        {
            get {return codigoDeBarras;}
        }

        public float Valor { get; internal set; }
        public DateTime Data { get; internal set; }

        public override string Desconto(int valor)
        {
            throw new NotImplementedException();
        }

        public void Registrar(float valor, DateTime dataEmissao, string codigoDeBarras)
        {
            Console.WriteLine($"O valor da compra fica em R${valor*0.88f}");
            Console.WriteLine($"Data de emissão = {dataEmissao}");
            Console.WriteLine($"Data de Vencimento = {dataEmissao.AddDays(10)}");
            Console.WriteLine($"Código de barras = {codigoDeBarras}");
        }
    }
}