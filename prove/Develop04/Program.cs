using System;

class Program
{
    static void Main(string[] args)
    {
        int menuChoice = 0;

        do 
        {
            Console.WriteLine();
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("    1. Start breathing activity");
            Console.WriteLine("    2. Start reflecting activity");
            Console.WriteLine("    3. Starting listing activity");
            Console.WriteLine("    4. Quit");
            Console.WriteLine("Select a choice from the menu: ");
            menuChoice = int.Parse(Console.ReadLine());

            switch(menuChoice)
            {
                case 1:
                    BreathActivity breath = new BreathActivity();
                    breath.displayStartingMessage();
                    breath.displayDescription();
                    breath.getSessionDuration();

                    breath.showGetReadyMsg();
                    breath.showSpinner();

                    breath.breatheFor();

                    breath.displayEndingMessage();
                    break;
                case 2: 
                    ReflectionActivity reflect = new ReflectionActivity();
                    reflect.displayStartingMessage();
                    reflect.displayDescription();
                    reflect.getSessionDuration();

                    reflect.showGetReadyMsg();
                    reflect.showSpinner();

                    reflect.displayRandomPrompt();
                    reflect.waitForSomethingInMind();


                    reflect.displayAllFollowupPrompts();

                    reflect.displayEndingMessage();

                    break;
                case 3:
                    ListingActivity listing = new ListingActivity();
                    listing.displayStartingMessage();
                    listing.displayDescription();
                    listing.getSessionDuration();

                    listing.showGetReadyMsg();
                    listing.showSpinner();

                    listing.collectAndCountListings();

                    listing.displayEndingMessage();

                    break;
                case 4: 
                    Console.WriteLine();
                    Console.WriteLine("Bye Bye! See you next time.");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("You have entered a number we don't recognize. Please choose a number 1-4.");                     
                    break;
            }

        } while(menuChoice <= 4);

    }     
       
}