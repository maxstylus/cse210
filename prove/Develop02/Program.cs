using System;

class Program
{       

    private static void displayWelcome()
    {
        Console.WriteLine("Please select one of the following choices: ");
    }

    private static void displayMenu()
    {
        Console.WriteLine();
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Read uplifting message");
        Console.WriteLine("6. Quit");
        Console.WriteLine();
    }

    static void Main(string[] args)
    {       
        displayWelcome();
        int choice = 0;

        Journal journal = new Journal();

        do
        {            
            displayMenu();

            Console.Write("What would you like to do? ");
            Console.WriteLine();

            Entry entry = new Entry();
            choice = Convert.ToInt32(Console.ReadLine());
            
            switch (choice)
            {
                case 1:
                    // Save date, prompt, journal entry to a list of journal entries. (on journal class)?
                    Console.WriteLine();                   
                    entry.displayJournalPrompt();
                    entry.readJournalEntry();

                    journal._allEntries.Add(entry);                     
                    break;
                case 2:                    
                    // Use Journal class to display all entries in the list
                    journal.display();
                    break;
                case 3:                
                    // open, read and display from journal file
                    journal.readFromTxtFile();
                    break;
                case 4:          
                    // Write the list of entries from journal class to file. 
                    journal.saveToTxtFile();
                    break;
                case 5: 
                    Console.WriteLine();
                    Console.WriteLine(PromptGenerator.getUpliftingMessage());
                    Console.WriteLine();
                    break;
                case 6: 
                    Console.WriteLine("Closing your Journal. See you next time.");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("You have entered a number we don't recognize. Please choose a number 1-6.");                     
                    break;
            }
        } while (choice < 6);
         
    }
}
