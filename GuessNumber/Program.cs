using System;

namespace GuessNumber
{
    class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();

            Console.WriteLine("Valg to tal, som det mindste og største værdi af tal du kan gætte på. Start med mindste og derefter det største");

            int min = Convert.ToInt16(Console.ReadLine());
            int max = Convert.ToInt16(Console.ReadLine());
            
            int numberToGuess = random.Next(min, max);
            int guess = 0;
            int guesses = 0;

            Console.WriteLine("Hvad gætter du på tallet er? Det er imellem {0} og {1}", min, max);
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
