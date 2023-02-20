using System;

public class SimpleGoal : Goal
{
    private bool _isComplete = false;

    public SimpleGoal()
    {
        // string name, string description, int points, bool goalComplete
    }

    public void setGoalComplete(Boolean isComplete)
    {
        _isComplete = isComplete;
    }

    public bool getGoalComplete()
    {
        return _isComplete;
    }

    public override string getGoalAsString()
    {
        string mySimpleGoal = ($"[ ] {getName()}, ({getDescription()})");
        return mySimpleGoal;
    }

    public override string getGoalAsStringToSaveToCSV()
    {
        string myGoal = ($"Simple Goal, {getName()}, {getDescription()}, {getPoints().ToString()}, {_isComplete}");
        return myGoal;
    }

    public override void recordEvent()
    {
        Console.WriteLine($"Congratulations! You have earned {getPoints()}!");
        _isComplete = true;
    }









    
}