using System.Text;

class SaveLoadCSV
{
    public static void SaveToCSV(List<string> dataToSave)
    {
        Totals totals = new Totals();
        string totalPoints = totals.getPoints().ToString();
        
        Console.WriteLine("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();

        string subdirectory = "Files";
        string filePath = Path.Combine(Directory.GetCurrentDirectory(), subdirectory, fileName);
        File.WriteAllText(filePath, totalPoints);
        File.WriteAllLines(filePath, dataToSave);

        Console.WriteLine("Goals Saved");
    }

    public static List<String> LoadFromCSV()
    {
        Console.WriteLine("What filename would you like to load? ");
        string fileName = Console.ReadLine();
        
        string subdirectory = "Files";
        string filePath = Path.Combine(Directory.GetCurrentDirectory(), subdirectory, fileName);

        List<string> fromCSV        = new List<string>();
        StreamReader streamReader   = new StreamReader(filePath);

        while (!streamReader.EndOfStream)
        {
            string line = streamReader.ReadLine();
            fromCSV.Add(line.ToString());
        }
        streamReader.Close();

        return fromCSV;
    }

}