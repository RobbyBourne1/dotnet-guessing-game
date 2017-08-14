using System;

namespace dotnet_guessing_game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var random = new Random();
            int randomNumber = random.Next(0, 100);
            Console.WriteLine(randomNumber);
            var input = Convert.ToInt32(Console.ReadLine());
            if (input > randomNumber);
            {
                Console.WriteLine("Number is too high!");
            }
        }
    }
}
