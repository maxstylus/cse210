using System;

public class Activity
{
    protected int _duration = 0;
    protected string _activityType = "unassigned";

    public void getSessionDuration()
    {
        Console.WriteLine();
        Console.WriteLine("How long, in seconds, would you like for your session?");
        _duration = Convert.ToInt32(Console.ReadLine());
    }

    public void countDownFrom(int number)
    {   

        for (int i = number; i >= 1; i--)
            {
                Console.Write(i);
                pause(1);
                Console.Write("\b");
            }
        
        // Clear the countdown when finished.
        Console.Write(" ");
    }

    public void pause(int seconds)
    {       
        Thread.Sleep(seconds * 1000);
    }

    public void showGetReadyMsg()
    {
        Console.WriteLine();
        Console.WriteLine("Get ready...");
    }

    public void showSpinner()
    {

        List<string> spinners = new List<string>();
            spinners.Add("\\");
            spinners.Add("|");
            spinners.Add("/");
            spinners.Add("-");      
        
        for (int i = 0; i < 4; i++)
            {
                foreach(string spinner in spinners)
                {
                    Console.Write(spinner);
                    Thread.Sleep(500);
                    Console.Write("\b \b"); // Erase the + character
                }
            }  

        Console.WriteLine();     
    }

    public void displayStartingMessage()
    {
        Console.WriteLine();
        Console.WriteLine($"Welcome to the {_activityType} Activity");
        Console.WriteLine();
    }

    public void displayEndingMessage()
    {
        Console.WriteLine("Well done!");
        showSpinner();

        Console.WriteLine($"You have completed another {_duration} seconds of the {_activityType} Activity.");
        showSpinner();
    }

}