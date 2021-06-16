using System;

namespace DesafioDojo1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Desafio DojoPuzzle Jokenpo
            // https://dojopuzzles.com/problems/jokenpo/


            System.Console.WriteLine("Escolha pedra, papel ou tesoura para o jogador 1");
            string jogador1 = Console.ReadLine();
            
            System.Console.WriteLine("Escolha pedra, papel ou tesoura para o jogador 2");
            string jogador2 = Console.ReadLine();

            
            if(jogador1 == jogador2){
            System.Console.WriteLine("Os jogadores empataram");
            }
            


            if(jogador1 == "pedra" && jogador2 == "papel"){
                System.Console.WriteLine("O jogador 2 ganhou");
            }
            if(jogador1 == "papel" && jogador2 == "pedra"){
                System.Console.WriteLine("O jogador 1 ganhou");
            }


            if(jogador1 == "pedra" && jogador2 == "tesoura"){
                System.Console.WriteLine("O jogador 1 ganhou");
            }
            if(jogador1 == "tesoura" && jogador2 == "pedra"){
                System.Console.WriteLine("O jogador 2 ganhou");
            }


            if(jogador1 == "tesoura" && jogador2 == "papel"){
                System.Console.WriteLine("O jogador 1 ganhou");
            }
            if(jogador1 == "papel" && jogador2 == "tesoura"){
                System.Console.WriteLine("O jogador 2 ganhou");
            }
            else{
                System.Console.WriteLine("Por favor, digite apenas pedra, papel ou tesoura");
            }
        }
    }
}
