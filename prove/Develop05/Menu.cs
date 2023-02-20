public static class Menu
{
        public static void displayMainMenu()
        {
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("    1. Create New Goal");
            Console.WriteLine("    2. List Goals");
            Console.WriteLine("    3. Save Goals");
            Console.WriteLine("    4. Load Goals");
            Console.WriteLine("    5. Record Event");
            Console.WriteLine("    6. Quit");
        }

        public static void displayGoalTypeMenu()
        {
            Console.WriteLine();
            Console.WriteLine("The types of goals are: ");
            Console.WriteLine("  1. Simple Goal");
            Console.WriteLine("  2. Eternal Goal");
            Console.WriteLine("  3. Checklist Goal");
        }

        public static int getMenuChoice()
        {
            Console.WriteLine("Select a choice from the menu: ");
            return int.Parse(Console.ReadLine());
        }

        public static int getGoalType()
        {
            Console.WriteLine("Which type of goal would you like to create?");
            return int.Parse(Console.ReadLine());
        }

}