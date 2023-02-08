
public class Entry
{
    public string _date = "";
    public string _prompt = "";
    public string _entry = "";

    public string getDate()
    {
        DateTime theCurrentTime = DateTime.Now;
        string currentDate = theCurrentTime.ToShortDateString();

        return currentDate;
    }

    // public string getPrompt()
    // {
    //     string _prompt = getRandomPrompt();
    //     return _prompt;
    // }

    public void displayJournalPrompt()
    {
        _prompt = PromptGenerator.getRandomPrompt(); //getPrompt();
        Console.WriteLine(_prompt);
        Console.Write("> ");        
    }

    public void readJournalEntry()
    {
        _entry = Console.ReadLine();
    }

    public void display()
    {
        // Date: 09/23/2021 Prompt: This is a journal prompt
        // Entry: This is a heartfelt journal entry. A journal entry can be multiple lines. 
        _date = getDate();

        Console.WriteLine($"Date: {_date} Prompt: {_prompt}");
        Console.WriteLine($"Entry: {_entry}");
    }        

    // public string getRandomPrompt()
    // {
    //     List<string> journalPrompts = new List<string>
    //     {
    //         "Who was the most interesting person I interacted with today?",
    //         "What was the best part of my day?",
    //         "How did I see the hand of the Lord in my life today?",
    //         "What was the strongest emotion I felt today?",
    //         "If I had one thing I could do over today, what would it be?", 
    //         "What was a lesson learnt today?", 
    //         "Who did I help today?"
    //     };  
        
    //     var random = new Random();
    //     int index = random.Next(journalPrompts.Count);
    //     string prompt = journalPrompts[index];

    //     return prompt;       
    // }
}