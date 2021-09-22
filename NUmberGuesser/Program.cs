using System;

namespace NUmberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            GetAppInfo(); // GetAppInfo function run

            GreetUser(); // GreetUser function run

            while (true)
            {

                // set correct number
                //int correctNumber = 7;

                //create a new random object
                Random random = new Random();

                int correctNumber = random.Next(1, 11);

                // init gess var
                int guess = 0;


                // ask user for number
                Console.WriteLine("Guess a number between 1 and 10.");

                // while guess is not correct
                while (guess != correctNumber)
                {
                    // get user input
                    string input = Console.ReadLine();

                    // make sure its a number
                    if (!int.TryParse(input, out guess))
                    {
                        // print error message 
                        PrintColorMessage(ConsoleColor.Red, "Please use an actual number!");


                        // keep going
                        continue;
                    }

                    // Cast to int and put in guess
                    guess = Int32.Parse(input);

                    // match guess to correct number
                    if (guess != correctNumber)
                    {
                        // set error message
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, try again");
                    }


                }

                // set correct message
                PrintColorMessage(ConsoleColor.Yellow, "You are Correct!");

                // ask to play again
                Console.WriteLine("Play Again? [Y or N]");

                // Get answer
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
        // get and display info
        static void GetAppInfo()
        {
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Aron Palmsaar";

            // change text color
            Console.ForegroundColor = ConsoleColor.Green;

            // write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);
            // reset text color

            Console.ResetColor();
        }
        // Get and greet user
        static void GreetUser()
        {
            // ask users name
            Console.WriteLine("What is your name?");

            // get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game!", inputName);
        }
        // print color messega
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            // change text color
            Console.ForegroundColor = color;

            // its not a number
            Console.WriteLine(message);
            // reset text color

            Console.ResetColor();
        }

    }
}
