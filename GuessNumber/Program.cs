using System;

namespace GuessNumber
{
    class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();



            int numberToGuess = random.Next(1, 100);
            int guess = 0;
            int guesses = 0;

            Console.WriteLine("Hvad gætter du på tallet er?");
            while (guess != numberToGuess)
            {
                guesses++;
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
                    Console.WriteLine("Tillykke, du har gættede det rigtige tal.");
                    Console.WriteLine("Du brugte {0} forsøg på at gætte rigtigt", guesses);
                }
            }
        }
    }
}
