using System;
//Namespace
namespace NumberGuesser
{
    //Main Class
    class Program
    {
        //Entry Point Method
        static void Main(string[] args)
        {
            GetAppInfo(); // Run GetAppInfo function to get 

            GreetUser(); // Ask for users name and greet

            while (true)
            {
                //int correctNumber = 7;

                // Create a new Random object
                Random random = new Random();

                // Init correct number
                int correctNumber = random.Next(1, 10);

                //Init guess var
                int guess = 0;

                //Ask user for number
                Console.WriteLine("Guess a number between 1 and 10");

                //While guess is not correct
                while (guess != correctNumber)
                {
                    //Get users input
                    string input = Console.ReadLine();


                    //Make sure a number is inputted
                    if (!int.TryParse(input, out guess))
                    {
                        //Print error message
                        PrintColorMessage(ConsoleColor.Red, "Please use an actual number");
                        
                        //Keep going
                        continue;
                    }

                    //Cast to int and put in guess
                    guess = Int32.Parse(input);

                    //Match guess to correct number
                    if (guess != correctNumber)
                    {
                        //Print error message
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again");
                    }

                }


                //Output success message
                PrintColorMessage(ConsoleColor.Yellow, "You are CORRECT!!!");

                //Ask to play again
                Console.WriteLine("Play Again? [Y or N]");

                // get answer

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

        //ask users name and greet
        static void GetAppInfo()
        {
            // Set app vars

            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Sam Raha";

            //Change Text color
            Console.ForegroundColor = ConsoleColor.Green;


            //Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            //resetting console colour
            Console.ResetColor();

        }
        //Get and display app info
        static void GreetUser()
        {
            //Ask users name
            Console.WriteLine("What is your name?");

            //Get user input 
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game...", inputName);
        }

        // Print color message 

        static void PrintColorMessage(ConsoleColor color, string message)
        {
            //Change Text color
            Console.ForegroundColor = color

            //Tell user wjat they've input is not a number
            Console.WriteLine(message);

            //resetting console colour
            Console.ResetColor();

        }
    }
}
