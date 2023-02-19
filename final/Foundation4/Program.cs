using System;

class Program
{
    static void Main(string[] args)
    {
        // Write a program that creates at least one activity of each type. 
        // Put each of these activities in the same list. 
        // Iterate through this list and call the GetSummary method on each item and display the results.

        List<Activity> allActivities = new List<Activity>();

        string activityDate = DateTime.Now.ToString("dd MMM yyyy");

        Running running = new Running(3);
        running.setDate(activityDate);
        running.setLength(45);

        allActivities.Add(running);
        

        StationaryBiking cycling = new StationaryBiking(15);
        cycling.setDate(activityDate);
        cycling.setLength(25);

        allActivities.Add(cycling);


        SwimmingLapPool swimming = new SwimmingLapPool(20);
        swimming.setDate(activityDate);
        swimming.setLength(40);

        allActivities.Add(swimming);

        foreach (Activity activity in allActivities)
        {
            Console.WriteLine("\n-------------------------------------");
            Console.WriteLine(activity.getSummary());
            Console.WriteLine("-------------------------------------\n");
        }

    }
}