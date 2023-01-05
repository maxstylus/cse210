using System;

class Program
{
    static void Main(string[] args)
    {
        // DisplayWelcome - Displays the message, "Welcome to the Program!"
        // PromptUserName - Asks for and returns the user's name (as a string)
        // PromptUserNumber - Asks for and returns the user's favorite number (as an integer)
        // SquareNumber - Accepts an integer as a parameter and returns that number squared (as an integer)
        // DisplayResult - Accepts the user's name and the squared number and displays them.

        // Welcome to the program!
        // Please enter your name: Brother Burton
        // Please enter your favorite number: 42
        // Brother Burton, the square of your number is 1764

        DisplayWelcome();
        string name = PromptUserName();
        int favorite_number = PromptUserFavoriteNumber();
        int square = SquareNumber(favorite_number);
        DisplayResults(name, square);

    }


    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.WriteLine("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    static int PromptUserFavoriteNumber()
    {
        Console.WriteLine("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    static void DisplayResults(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square.ToString()}");
    }
}