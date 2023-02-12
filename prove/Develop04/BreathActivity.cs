public class BreathActivity : Activity
{    

    private string _description = @"This activity will help you relax by walking you through breathing in and out slowly. 
    Clear your mind and focus on your breathing.";

    public BreathActivity()
    {
        _activityType = "Breathe";
    }

    public void displayDescription()
    {
        Console.WriteLine(_description);
    }

    public void breatheFor()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);

        DateTime currentTime = DateTime.Now;
        while (currentTime < futureTime)
        {
            Console.WriteLine();
            Console.Write("Breathe in...");
            countDownFrom(4);
            pause(1);
            Console.WriteLine();
            Console.Write("Breathe out...");
            countDownFrom(6);

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("    ~~~~~~ ");
            Console.WriteLine();

            currentTime = DateTime.Now;
        } 
    }
}