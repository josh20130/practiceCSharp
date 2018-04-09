using System;


namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            //Run get info function
            GetAppInfo();

            //Ask for user's name and greet
            GreetUser();

            while (true)
            {
                //Create a new random object
                Random random = new Random();
                //Init correct number
                int correctnumber = random.Next(1, 10);

                //Init correct number
                //int correctnumber = 7;

                //Init guess var
                int guess = 0;

                Console.WriteLine("Guess a number between 1 and 10");

                //Loop for asking user for correct answer
                while (guess != correctnumber)
                {
                    string input = Console.ReadLine();

                    //Make sure it's a number
                    if (!int.TryParse(input, out guess))
                    {
                        //Print error message
                        PrintColorMessage(ConsoleColor.Red, "Please enter only numbers");

                        //Keep going
                        continue;
                    }
                    //Cast to int
                    guess = Int32.Parse(input);

                    //Match guess to correct number
                    if (guess != correctnumber)
                    {
                        //Print error message
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again");
                    }
                }
                //Output success message
                PrintColorMessage(ConsoleColor.Yellow, "Correct!");

                //Ask to play again
                Console.WriteLine("Would you like to play again [Y or N]");

                //Get answer
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
    
    //Get and display app info
    static void GetAppInfo()
    {

        //Set app vars
        string appName = "Number Guesser";
        string appVersion = "1.0.0";
        string appAuthor = "Josh Smith";

        //Change text color
        Console.ForegroundColor = ConsoleColor.Green;

        //Write out app info
        Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

        //Reset text color
        Console.ResetColor();

    }
    //Ask user's name and greet
    static void GreetUser()
    {
        //Ask users name
        Console.WriteLine("What is your name");

        //get user input
        string inputName = Console.ReadLine();

        Console.WriteLine("Hello {0}, let's play a game...", inputName);
    }

    //Print color message
    static void PrintColorMessage(ConsoleColor color, string message)
    {
        //Change text color
        Console.ForegroundColor = color;

        //Tell user it's not a number
        Console.WriteLine(message);

        //Reset text color
        Console.ResetColor();

    }
}

    }

