public class ReflectionActivity : Activity
{    

    private string _description = @"This activity will help you reflect on times in your life when you have shown strength and resilience.
	This will help you recognize the power you have and how you can use it in other aspects of your life.";

    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.", 
        "Think of a time when you did something really difficult.", 
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _followupPrompts = new List<string>
    {
        "Why was this experience meaningful to you?  ", 
        "Have you ever done anything like this before?  ",
        "How did you get started?  ",
        "How did you feel when it was complete?  ", 
        "What made this time different than other times when you were not as successful?  ", 
        "What is your favorite thing about this experience?  ", 
        "What could you learn from this experience that applies to other situations?  ", 
        "What did you learn about yourself through this experience?  ", 
        "How can you keep this experience in mind in the future?  "
    };

    public ReflectionActivity()
    {
        _activityType = "Reflection";
    }

    public void displayDescription()
    {
        Console.WriteLine(_description);
    }

    public void displayRandomPrompt()
    {
        Console.WriteLine();
        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine();
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
        Console.WriteLine();
    }

    public void displayAllFollowupPrompts()
    { 
        Console.WriteLine();
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience");
        Console.Write("You may begin in: ");
        countDownFrom(4);
        Console.WriteLine();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);

        DateTime currentTime = DateTime.Now;
        while (currentTime < futureTime)
        {
                Console.WriteLine();
                Console.Write(PickRandomString());
                showSpinner();
                Console.WriteLine();
            
            currentTime = DateTime.Now;
        }


    }

    private Random _random = new Random();

    public string GetRandomPrompt()
    {
        int index = _random.Next(0, _prompts.Count);
        return _prompts[index];
    }

    public string GetRandomFollowupPrompt()
    {
        int index = _random.Next(0, _followupPrompts.Count);
        return  _followupPrompts[index];
    }
    private List<string> _selectedWords = new List<string>();

    public string PickRandomString()
    {
        string selected = GetRandomFollowupPrompt();
        
        if (_selectedWords.Contains(selected))
        {
            return PickRandomString();
        }

        _selectedWords.Add(selected);
        return selected;
    }

    public void waitForSomethingInMind()
    {
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
    }

}