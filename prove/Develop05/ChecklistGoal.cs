using System;

public class ChecklistGoal : Goal
{
    private int _numTimesToComplete = 0;

    private int _numHasCompleted = 0;

    private bool _isComplete = false;
    
    private int _bonus = 0; 

    
    public int getNumTimesToComplete() => _numTimesToComplete;

    public int getBonus() => _bonus;

    public int setNumTimesToComplete(int numTimes) => _numTimesToComplete = numTimes;

    public int setBonus(int bonus) => _bonus = bonus;
    
    public void askNumTimesToComplete()
    {
        Console.WriteLine();
        Console.WriteLine("How many times does this goal need to be accomplished for a bonus?");
        setNumTimesToComplete(int.Parse(Console.ReadLine()));
        Console.WriteLine();
    }

    public override void updateChecklist()
    {
        if (_numHasCompleted < _numTimesToComplete)
        {
            increaseCompletedByOne();
        } else
        {
            _isComplete = true;
        }
    }

    public void increaseCompletedByOne()
    {
        _numHasCompleted += 1;
    }

    public void askBonusAmount()
    {
        Console.WriteLine();
        Console.WriteLine("What is the bonus amount for accomplishing it that many times?");
        setBonus(int.Parse(Console.ReadLine()));
        Console.WriteLine();
    }

   public override string getGoalAsString()
    {
        string mySimpleGoal = ($"[{((_isComplete == false) ? " " : "X")}] {getName()}, ({getDescription()}) -- Currently Completed: {_numHasCompleted}/{_numTimesToComplete}");
        return mySimpleGoal;
    }

    public override string getGoalAsStringToSaveToCSV()
    {
        string myGoal = ($"Checklist Goal, {getName()}, {getDescription()}, {getPoints().ToString()}, {_bonus}, {_numTimesToComplete}, {_numHasCompleted}");
        return myGoal;
    }
    
}