using System;

namespace DesafioDojo3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Desafio DojoPuzzle Caixa eletrônico
            // https://dojopuzzles.com/problems/caixa-eletronico/

            int qtd100 = 0;
            int qtd50 = 0;
            int qtd20 = 0;
            int qtd10 = 0;
            

            System.Console.WriteLine("Digite a quantidade que você deseja sacar");
            int valor = Int32.Parse(Console.ReadLine());
        
                if (valor >= 100) {
                qtd100 = (valor / 100);
                valor = valor - (100 * qtd100);
                }

                if (valor >= 50) {
                qtd50 = (valor / 50);
                valor = valor - (50 * qtd50);
                }

                if (valor >= 20) {
                qtd20 = (valor / 20);
                valor = valor - (20 * qtd20);
                }

                if (valor >= 10) {
                qtd10 = (valor / 10);
                valor = valor - (10 * qtd10);
                }

                System.Console.WriteLine("Você sacou:");
                System.Console.WriteLine($"{qtd100} notas de 100");
                System.Console.WriteLine($"{qtd50} notas de 50");
                System.Console.WriteLine($"{qtd20} notas de 20");
                System.Console.WriteLine($"{qtd10} notas de 10");

            
        }
    }
}
