//Command line number guesser game made following a youtube tutorial. I made this to familiarize myself with the framework, mainly the 
//command line functions.
using System;

namespace NumberGuesser
{
    class Program
    {
        static String appName = "Number Guesser";
        static void GetAppInfo()
        {
            //Header
            
            string appVersion = "1.0.0";
            string author = "Jordance Webb";

            //Make text red for header
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, author);

            //Change it back
            Console.ResetColor();
        }
        static void GreetUser()
        {
            //get user's name
            Console.WriteLine("What's Your Name?");
            String usersName = Console.ReadLine();

            //Read it back to them
            Console.WriteLine("Hello, " + usersName + ", Let's Play " + appName);
        }
        static void PrintWithColor(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
        static void Main(string[] args)
        {
            GetAppInfo();
            GreetUser();

            while (true)
            {

                //Create Random Object
                Random random = new Random();
                int correctNumber = random.Next(1, 10);

                int guess = 0;

                //Ask user for number
                Console.WriteLine("Guess a number between 1 and 9");

                while (guess != correctNumber)
                {
                    //Get user input
                    string input = Console.ReadLine();

                    if (!int.TryParse(input, out guess))
                    {
                        PrintWithColor("Please enter an actual number", ConsoleColor.Red);
                        continue;
                    }
                    //Cast to int and put in guess
                    guess = Int32.Parse(input);

                    //MAtch guess to correct #
                    if (guess != correctNumber)
                    {
                        PrintWithColor("Wrong number. Please try again", ConsoleColor.Red);
                       // Console.WriteLine(correctNumber);
                    }
                }
                //Output success message
                PrintWithColor("Correct!", ConsoleColor.Green);

                Console.WriteLine("Play again? Y/N");
                string answer = Console.ReadLine().ToUpper();

                if(answer == "Y")
                {
                    continue;
                }
                else if(answer == "N")
                {
                    return;
                }
            }
        }
    }
}
