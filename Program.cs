using System;
using Abstração.classes;

namespace Abstração
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine ("Digite o valor da compra: ");
            float valorDaCompra = float.Parse(Console.ReadLine());

            Console.WriteLine("Selecione o tipo de pagamento: \n1 - Boleto \n2 - Cartão");
            int opcao = int.Parse(Console.ReadLine());

            switch(opcao)
            {
                //boleto
                case 1:
                    Boleto boleto = new Boleto();
                    boleto.Valor = valorDaCompra;
                    boleto.Registrar(boleto.Valor, boleto.Data, boleto.CodigoDeBarras);
                    break;

                //cartão
                case 2:
                    Console.WriteLine("Selecione o tipo de pagamento no cartão: \n1 - Crédito \n2 - Débito");
                    int tipoCartao = int.Parse(Console.ReadLine());

                switch (tipoCartao)
                {
                    //crédito
                    case 1:
                        Credito credito     = new Credito();
                        credito.numero      = "12334.123123.123123";
                        credito.bandeira    = "MasterCard";
                        credito.cvv         = "123";
                        credito.titular     = "Kemilly Ferreira";
                        credito.Pagar(valorDaCompra);
                        break;
                    
                    default:
                        break;
                }

                break;
                
            }
        }
    }
}
