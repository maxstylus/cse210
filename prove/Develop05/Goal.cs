using System;

public class Goal
{

    private string _name = "";
    private string _description = "";
    private int _points = 0;

    public string getName() => _name;
    public string getDescription() => _description;
    public int getPoints() => _points;

    public string setName(string name) => _name = name;
    public string setDescription(string description) => _description = description;
    public int setPoints(int points) => _points = points;

    public void askName()
    {
        Console.WriteLine();
        Console.WriteLine("What is the name of your goal?");
        setName(Console.ReadLine());
        Console.WriteLine();
    }

    public void askDescription()
    {
        Console.WriteLine();
        Console.WriteLine("What is a short description of it?");
        setDescription(Console.ReadLine());
        Console.WriteLine();
    }

    public void askGoalPoints()
    {
        Console.WriteLine();
        Console.WriteLine("What is the amount of points associated with this goal?");
        setPoints(int.Parse(Console.ReadLine()));
        Console.WriteLine();
    }

   public virtual string getGoalAsString()
    {
        string mySimpleGoal = ($"[ ] {getName()}, ({getDescription()})");
        return mySimpleGoal;
    }

    public virtual string getGoalAsStringToSaveToCSV()
    {
        string myGoal = ($"[ ] {getName()}, {getDescription()}, {getPoints().ToString()}");
        return myGoal;
    }

    public string getGoalAsTitleOnly()
    {
        string myGoal = ($"{getName()}");
        return myGoal;
    }

    public virtual void recordEvent()
    {
        Console.WriteLine($"Congratulations! You have earned {getPoints()}!");
    }


}