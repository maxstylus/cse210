using System;

class Program
{
    static void Main(string[] args)
    {
        // Extra Credit Work
        // Randomly selects a scripture and reference from a Scripture Selector class 
        // that contains a method that stores dictionary of scripture, verse pairs
        // and randomly returns one of them. 
        
        ScriptureSelector scriptureSelector = new ScriptureSelector(); 
        
        Tuple<string, List<string>> result = scriptureSelector.getRandomScripturePair();
        string scriptureToStudy = result.Item1;
        List<string> referenceList = result.Item2;  

        var book = referenceList[0];
        var chapter = referenceList[1];
        var verse = referenceList[2];  

        Reference scriptureReference = new Reference(book, chapter, verse); //"Proverbs", "3", "5-6"
        Scripture scripture = new Scripture(scriptureReference, scriptureToStudy);
        ScriptureMemorizer scriptureMemorizer = new ScriptureMemorizer(scripture);

        string userInput = ""; 

        while (userInput != "quit" && scriptureMemorizer.hasWordsLeft() == true)
        {
            Console.Clear();

            Console.WriteLine(string.Format("{0} {1}", scriptureReference.toString(), scriptureMemorizer.toString()));
            Console.WriteLine(); 
            string input = Console.ReadLine();
            if (input.Equals("quit", StringComparison.OrdinalIgnoreCase))
            {
                break;
            }
            scriptureMemorizer.removeWordsFromText();
        }
    }
}