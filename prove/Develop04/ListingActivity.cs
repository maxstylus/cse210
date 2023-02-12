public class ListingActivity : Activity
{    

    private string _description = @"This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";

    public ListingActivity()
    {
        _activityType = "Listing";
    }

    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?", 
        "What are personal strengths of yours?", 
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public void displayDescription()
    {
        Console.WriteLine(_description);
    }

    public void displayRandomPrompt()
    {
        Console.WriteLine();
        Console.WriteLine("List as many responses you can to the following prompt: ");
        Console.WriteLine();
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
        Console.WriteLine();
    }

    private Random _random = new Random();

    private string GetRandomPrompt()
    {
        int index = _random.Next(0, _prompts.Count);
        return _prompts[index];
    }

    public void collectAndCountListings()
    {
        List<string> listings = new List<string>();

        displayRandomPrompt();
        
        Console.WriteLine();
        Console.Write("You may begin in: ");
        countDownFrom(4);
        Console.WriteLine();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);

        DateTime currentTime = DateTime.Now;
        while (currentTime < futureTime)
        { 
            Console.Write("> ");
            string input = Console.ReadLine();
            listings.Add(input);          
            
            currentTime = DateTime.Now;
        }

        Console.WriteLine();
        Console.WriteLine($"You listed {listings.Count} items!");

    }
    
}