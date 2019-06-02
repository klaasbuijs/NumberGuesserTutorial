using System;

// Namespace
namespace NumberGuesser
{
    // main Class
    class Program
    {
        // Entry Point Method
        static void Main(string[] args)
        {
            // void means there is no return type
            // static means it's not refering to class object
            Console.WriteLine("Let's play a game!");

            while(true)
            {
                // initialize number for guessing game
                Random random = new Random();
                int correctNumber = random.Next(1, 10);

                // initialize guess int
                int userGuess = 0;

                Console.WriteLine("Please guess the number between 1 and 10:");
                // ask user for number
                while (userGuess != correctNumber)
                {
                    // get user input
                    string input = Console.ReadLine();

                    // check input
                    if (!int.TryParse(input, out userGuess))
                    {
                        OutputConsoleMessage(ConsoleColor.Yellow, "Please enter an actual number!");
                        continue;
                    }

                    // cast string to int
                    userGuess = Int32.Parse(input);

                    if (userGuess != correctNumber)
                    {
                        OutputConsoleMessage(ConsoleColor.Red, "Wrong number, please try again.");

                    }
                }

                // output success message
                OutputConsoleMessage(ConsoleColor.Green, "You guessed the right number.");

                // ask user to play another game
                Console.WriteLine("Play another game? (Y or N)");
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }
            }
        }

        static void OutputConsoleMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
