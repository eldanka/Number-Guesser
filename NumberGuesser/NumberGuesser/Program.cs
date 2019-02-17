using System; 
// Namespace
namespace NumberGuesser
{
    //Main Class
    class Program
    {
        // Entry Point Method
        static void Main(string[] args)
        {
            AppInfo();

            GreetUser();

           

            while (true)
            {

                // Create new random object
                Random random = new Random();
                int correctNumber = random.Next(1, 10);

                // Init guess var
                int guess = 0;

                Console.WriteLine("Geuss a number between 1 and 10");

                // While guess is not correct
                while (guess != correctNumber)
                {
                    // Get users input
                    string input = Console.ReadLine();

                    // Make sure its a number
                    if (!int.TryParse(input, out guess))
                    {
                        PrintColorMessage(ConsoleColor.DarkRed, "Please enter a number!");
                        continue;
                    }

                    guess = int.Parse(input);


                    // Match guess to correct number
                    if (guess != correctNumber)
                    {   // Tell user its the wrong number
                        PrintColorMessage(ConsoleColor.DarkRed, "Wrong number, please try again!");
                    }
                    else
                    {   // Tell user its the correct number
                        PrintColorMessage(ConsoleColor.Green, "You are CORRECT!");
                    }

                    // Ask wonna play again



                }
                Console.WriteLine("Play Again? Y or N");

                // Get answer
                string answer = Console.ReadLine().ToUpper();

                if (answer.Equals("Y"))
                {
                    continue;
                }
                else if (answer.Equals("N"))
                {
                    return;
                }
                else
                {
                    return;
                }
            }

            Console.ReadLine();
        }

        static void AppInfo()
        {
            // START CODEING //
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Eldan Kahrovic";

            // Change text color
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("{0} : Version {1} by {2}", appName, appVersion, appAuthor);
            Console.WriteLine("-------------------------------------------------");

            // Reset text color
            Console.ResetColor();
        }

        static void GreetUser()
        {
            // Ask name
            Console.WriteLine("What is your name?");
            // Get user input
            string name = Console.ReadLine();
            Console.WriteLine(".................................................");
            Console.WriteLine("Hello {0}, let's play a game!", name);
        }

        static void PrintColorMessage(ConsoleColor color, string message)
        {
            // Tell user its not a number
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.WriteLine("-------------------------------------------------");
            Console.ResetColor();
        }

       
    }
}
