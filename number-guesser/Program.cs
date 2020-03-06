using System;

namespace number_guesser
{
    class Program
    {
        static void Main(string[] args)
        {
            GetAppInfo();

            GreetUser();

            while(true)
            {
                //int correctNum = 7;
                Random random = new Random();
                int correctNum = random.Next(1, 10);

                int guess = 0;

                Console.WriteLine("Guess a number between 1 and 10");

                while (guess != correctNum)
                {
                    string numInput = Console.ReadLine();
                    if (!int.TryParse(numInput, out guess)) // ENSURE ANSWER IS A NUMBER
                    {
                        PrintColorMsg(ConsoleColor.Red, "Must be a number"); // SET ERROR MESSAGE - WRONG INPUT TYPE

                        continue;
                    }
                    guess = Int32.Parse(numInput); // PARSING STRING INPUT INTO INT . . .

                    if (guess != correctNum)
                    {
                        PrintColorMsg(ConsoleColor.Red, "Wrong number, please try again"); // SET ERROR MESSAGE - WRONG ANSWER
                    }
                }

                PrintColorMsg(ConsoleColor.Cyan, "YOU GUESSED CORRECTLY!"); // SET MESSAGE - CORRECT ANSWER

                Console.WriteLine("Play Again? [Y or N]");

                string answer = Console.ReadLine().ToUpper();

                if(answer == "Y")
                {
                    continue;
                } 
                else if(answer == "N" || answer != "Y")
                {
                    return;
                }
            }
        }

        static void GetAppInfo()
        {
            string appName = "Number Guesser";
            string author = "Devin Graham";
            string version = "1.0.0";

            Console.ForegroundColor = ConsoleColor.Cyan; // CHANGE TEXT COLOR
            Console.WriteLine("{0} by {1}, Version: {2}", appName, author, version);
            Console.ResetColor(); // RESET TEXT COLOR AFTER USE
        }
        static void GreetUser()
        {
            Console.WriteLine("What is your name?"); // ASK USER'S NAME

            string input = Console.ReadLine(); // GET USER INPUT

            Console.WriteLine("Hello {0}, let's play a game . . .", input); // OUTPUT USER'S NAME WITH MESSAGE
        }

        static void PrintColorMsg(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
