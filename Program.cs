using System;

namespace dotnet_guessing_game
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 100);
            Console.WriteLine(randomNumber);
            Console.WriteLine("Pick a Number From 1 - 100");
            var input = int.Parse(Console.ReadLine());
            while (input != randomNumber)
            {
                if (input > randomNumber)
                {
                Console.WriteLine("Guess is too high!");
                input = int.Parse(Console.ReadLine());
                }
                else if (input < randomNumber)
                {
                Console.WriteLine("Guess is too Low!");
                input = int.Parse(Console.ReadLine());
                } 
            }
             if (input == randomNumber)
            {
                Console.WriteLine("You Guessed Right!");
            }
        }
    }
}
