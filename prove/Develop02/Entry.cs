
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

    public void displayJournalPrompt()
    {
        _prompt = PromptGenerator.getRandomPrompt(); 
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

}