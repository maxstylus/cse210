using System.IO; 

public class Journal
{
    public List<Entry> _allEntries = new List<Entry>();
    private string _textFileName = "journalEntries.txt";

    public void display()
    {
        foreach (Entry entry in _allEntries)
        {
            entry.display();
        }
    }

    public void saveToTxtFile()
    {
        string fileName = _textFileName;

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry entry in _allEntries)
            {
                outputFile.WriteLine($"Date: {entry._date} Prompt: {entry._prompt}");
                outputFile.WriteLine($"Entry: {entry._entry}");
            }

        }

        Console.WriteLine();
        Console.WriteLine("Save Complete!");
    }

    public void readFromTxtFile()
    {
        string filename = _textFileName;
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            Console.WriteLine(line);

        }
    }
}