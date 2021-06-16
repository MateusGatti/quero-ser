using System;

namespace DesafioDojo2
{
    class Program
    {
        static void Main(string[] args)
        {

            // Desafio DojoPuzzle FizzBuzz
            // https://dojopuzzles.com/problems/fizzbuzz/
            
            for(int a = 1; a < 101; a++){
                if(a % 3 == 0 && a % 5 == 0){
                    System.Console.Write(" FizzBuzz -");
                }
                if(a % 3 == 0){
                    System.Console.Write(" Fizz - ");
                }
                if(a % 5 == 0){
                    System.Console.Write(" Buzz - ");
                }
                else{
                    System.Console.Write(" " + a + " -");
                }
            }
        }
    }
}
