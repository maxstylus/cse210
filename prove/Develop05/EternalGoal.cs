using System;

public class EternalGoal : Goal
{

    // public override string getGoalAsString()
    // {
    //     string mySimpleGoal = ($"[ ] {getName()}, {getDescription()}, {getPoints()}");
    //     return mySimpleGoal;
    // }

    public override string getGoalAsStringToSaveToCSV()
    {
        string myGoal = ($"Eternal Goal, {getName()}, {getDescription()}, {getPoints().ToString()}");
        return myGoal;
    }


}