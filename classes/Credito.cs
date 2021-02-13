using System;

namespace Abstração.classes
{
    public class Credito : Cartao
    {
        private float limite = 3000;

        public void Pagar(float valor)
        { 
            this.valor = valor;
            if (valor <= this.limite)
            
            //efetuar o pagamento
            {
                int parcelas;
                do
                {
                    Console.WriteLine("Selecione a quantidade de parcelas: \n0 - À vista \n1 - 1x com jutos de 5% \n2 - 2x com jutos de 5% \n3 - 3x com juros de 5% \n4 - 4x com jutoos de 5% \n5 - 5x com juros de 5% \n6 - 6x com juros de 5% \n7 - 7x com juros de 8% \n8 - 8x com juros de 8% \n9 - 9x com juros de 8% \n10 - 10x com juros de 8% \n11 - 11x com juros de 8% \n12 - 12x com juros de 8%");
                    parcelas = int.Parse(Console.ReadLine());
                }while(parcelas > 12);

                float juros;
                if (parcelas <= 6)
                {
                    juros = 0.06f;
                }else
                {
                    juros = 0.08f;
                }

                float total = valor + (valor * juros);
                this.valor = total;

                ExibirNota(this.titular, total);
            }else
            {
                Console.WriteLine("Sem limite!");
            }
        }

        public void ExibirNota(string titular, float total)
        {
            Console.WriteLine($"Titular {titular} - Valor da compra = {total}");
        }

        public override string Desconto(int valor)
        {
            throw new NotImplementedException();
        }
    }
}