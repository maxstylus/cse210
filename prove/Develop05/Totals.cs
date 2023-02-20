public class Totals
{
    private int _points = 0;
    public List<Goal> _allGoals = new List<Goal>();

    public int getPoints()
    {
        return _points;
    }

    public void addToPoints(int points)
    {
        _points += points;
    }

    public void addGoalToGoals(Goal goal)
    {
        _allGoals.Add(goal);
    }

    public List<Goal> getAllGoals()
    {
        return _allGoals;
    }

    public void displayAllGoals()
    {
        int count = 1;
        
        Console.WriteLine("\nThe goals are: \n"); 
        
        foreach (Goal goal in _allGoals)
        {
            Console.Write($"{count}. ");
            Console.WriteLine(goal.getGoalAsString());
            count++;
        }
    }

    public void displayAllGoalsTitles()
    {
        int count = 1;
        
        Console.WriteLine("\nThe goals are: \n"); 
        
        foreach (Goal goal in _allGoals)
        {
            Console.Write($"{count}. ");
            Console.WriteLine(goal.getGoalAsTitleOnly());
            count++;
        }

        Console.WriteLine();
    }

    public List<string> getAllGoalsToSave()
    {
        List<string> goals = new List<string>();
        
        foreach (Goal goal in _allGoals)
        {
            goals.Add(goal.getGoalAsStringToSaveToCSV());
        }

        return goals;
    }

    public void loadGoals()
    {
        List<string> goals = SaveLoadCSV.LoadFromCSV();
        Console.WriteLine();

        Console.WriteLine($"\n The goals are: ");
        foreach (String goal in goals)
        {
            string[] goalParts = goal.Split(",");
            string myGoalType = goalParts[0];
            

            switch(myGoalType)
            {
                case "Simple Goal":
                    if (goalParts[3] == "True" || goalParts[3] == "true")
                    {
                        Console.WriteLine($"[X] {goalParts[1]}, ({goalParts[2]})"); 
                    }
                    else
                    {
                        Console.WriteLine($"[ ] {goalParts[1]}, ({goalParts[2]})");
                    }                                
                    break;
                case "Eternal Goal":
                    Console.WriteLine($"[ ] {goalParts[1]}, ({goalParts[2]})"); 
                    break;
                case "Checklist Goal":
                    // ($"[ ] {getName()}, ({getDescription()}) -- Currently Completed: {_completed}/{_numTimesToComplete}");
                    if (goalParts[5] == goalParts[6])
                    {
                        Console.WriteLine($"[X] {goalParts[1]}, ({goalParts[2]}) -- Currently Completed: {goalParts[6]}/{goalParts[5]}");
                    } 
                    else
                    {
                        Console.WriteLine($"[ ] {goalParts[1]}, ({goalParts[2]}) -- Currently Completed: {goalParts[6]}/{goalParts[5]}");

                    }
                    break;
                default: 
                    Console.WriteLine("ERROR! We don't recognize this goal type.");
                    break;
            }
        }
    }

    public void recordEvent()
    {
        Console.WriteLine("Which goal did you accomplish?");
        int goalNumber = int.Parse(Console.ReadLine());
        int index = goalNumber - 1;  // because index is zero based.
                    
        Goal updatedGoal = _allGoals[index];
        int goalPoints = updatedGoal.getPoints();
        updatedGoal.recordEvent();

        addToPoints(goalPoints);
        Console.WriteLine($"You now have {_points}.");

        // Not sure if these two lines are working >>        
        string goalString = updatedGoal.getGoalAsString();        
        goalString = goalString.Replace("[ ]", "[X]");


         
         // Locate 'goal' in the list of goals by index(goalNumber -1)
        // goal.getPoints()
        // totalPoints + goal.getPoints
        // locate goal string and replace "[ ]" with "[X]"
        // Print "Congratulations! You have earned {goal.getPoints}
        // Print "You now have totalPoints()

        // You have totalPoints
    }
}