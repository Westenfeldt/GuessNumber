using System;

namespace GuessNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberToGuess = 10;
            int guess = 0;

            Console.WriteLine("Hvad gætter du på tallet er?");
            while (guess != numberToGuess)
            {

                guess = Convert.ToInt16(Console.ReadLine());

                if (guess > numberToGuess)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Dit gæt på {0} er for højt, prøv igen", guess);
                } else if (guess < numberToGuess)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Dit gæt på {0} er for lavt, prøv igen", guess);
                } else if (guess == numberToGuess)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("TIllykke, du har gættede det rigtige tal.");
                }
            }
        }
    }
}
