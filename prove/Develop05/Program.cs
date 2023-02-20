using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\n**Welcome to EverQuest!**\n");
        Totals totals = new Totals();

        int menuChoice = 0;

        do 
        {
            Console.WriteLine($"\nYou have {totals.getPoints()} points.\n");

            Menu.displayMainMenu();
            menuChoice = Menu.getMenuChoice();

            switch(menuChoice) 
            {
                case 1: 
                    // Create New Goals
                    Menu.displayGoalTypeMenu();
                    int goalType = Menu.getGoalType();

                    switch(goalType)
                    {
                        case 1: 
                            // Simple Goal
                            SimpleGoal simpleGoal = new SimpleGoal();
                            simpleGoal.askName();
                            simpleGoal.askDescription();
                            simpleGoal.askGoalPoints();

                            totals.addGoalToGoals(simpleGoal);
                            break;
                        case 2:
                            // Eternal Goal 
                            EternalGoal eternalGoal = new EternalGoal();
                            eternalGoal.askName();
                            eternalGoal.askDescription();
                            eternalGoal.askGoalPoints();

                            totals.addGoalToGoals(eternalGoal);
                            break;
                        case 3: 
                            // Checklist Goal
                            ChecklistGoal checklistGoal = new ChecklistGoal();
                            checklistGoal.askName();
                            checklistGoal.askDescription();
                            checklistGoal.askGoalPoints();
                            checklistGoal.askNumTimesToComplete();
                            checklistGoal.askBonusAmount();

                            totals.addGoalToGoals(checklistGoal);
                            break;
                        default: 
                            Console.WriteLine("You have entered a number we don't recognize. Please choose a number 1-4.");
                            break; 
                    } 
                    break;
                case 2: 
                    // List Goals
                    totals.displayAllGoals();
                    break;
                case 3:
                    // Save Goals
                    SaveLoadCSV.SaveToCSV(totals.getAllGoalsToSave());
                    break; 
                case 4:
                    // Load Goals
                    totals.loadGoals();
                    break;
                case 5:
                    // Record Event
                    totals.displayAllGoalsTitles();

                    totals.recordEvent();
                    
                    break;
                case 6:
                    // Quit 
                    Console.WriteLine();
                    Console.WriteLine("Bye Bye! See you next time.");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("You have entered a number we don't recognize. Please choose a number 1-6.");                     
                    break;
            }

        } while(menuChoice <= 6);

    }
}