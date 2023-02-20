using System;

public class EternalGoal : Goal
{

    public override string getGoalAsStringToSaveToCSV()
    {
        string myGoal = ($"Eternal Goal, {getName()}, {getDescription()}, {getPoints().ToString()}");
        return myGoal;
    }


}