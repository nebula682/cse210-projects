using System;

class Program
{
    static void Main(string[] args)
    
    
    


    {
        DisplayWelcomeMessage();

        //asking the user for the user name

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(userNumber);

        //dispalying the results

        DisplayResult(userName, squaredNumber);
    }

    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        //asking the user for their name
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        //displaying the results

        return name;
    }

    static int PromptUserNumber()

    {
        // asking the user for their favorite number
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    //displaying the results

    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}

