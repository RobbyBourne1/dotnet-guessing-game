using System;

namespace dotnet_guessing_game
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            int randomNumber = random.Next(0, 100);
            Console.WriteLine(randomNumber);
            Console.WriteLine("Pick a Number From 1 - 100");
            var input = int.Parse(Console.ReadLine());
            if (input > randomNumber)
            {
                Console.WriteLine("Guess is too high!");
            }
            else if (input < randomNumber)
            {
                Console.WriteLine("Guess is too Low!");
            } 
            else if (input == randomNumber)
            {
                Console.WriteLine("You Guessed Right!");
            }
        }
    }
}
