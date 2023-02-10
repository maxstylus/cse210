using System;
using System.Collections;

public class ScriptureSelector
{

    public Tuple<string, List<string>> getRandomScripturePair()
    {
        Random random = new Random();

        string scripture1 = "Trust in the lord with all thine heart and lean not unto thine own understanding in all thy ways acknowledge him and he shall direct thy paths";
        string scripture2 = "For behold, this is my work and my glory, to bring to pass the immortality and eternal life of man";
        string scripture3 = "For I am not ashamed of the gospel of Christ: for it is the power of God unto salvation to every one that believeth to the Jew first and also to the Greek";
        string scripture4 = "And now as I said concerning faith faith is not to have a perfect knowledge of things; therefore if ye have faith ye hope for things which are not seen, which are true.";


        Dictionary<string, List<string>> scriptureMap = new Dictionary<string, List<string>>();

        List<string> reference1 = new List<string> {"Proverbs", "3", "5-6"};
        scriptureMap.Add(scripture1, reference1);
        
        List<string> reference2 = new List<string> {"Moses", "1", "39"};
        scriptureMap.Add(scripture2, reference2);
        
        List<string> reference3 = new List<string> {"Romans", "1", "16"};
        scriptureMap.Add(scripture3, reference3);
        
        List<string> reference4 = new List<string> {"Alma", "32", "21"};
        scriptureMap.Add(scripture4, reference4);

        List<KeyValuePair<string, List<string>>> scriptureList = scriptureMap.ToList();

        int index = random.Next(scriptureMap.Count);

        KeyValuePair<string, List<string>> randomPair = scriptureList[index];

        string key = randomPair.Key;
        List<string> value = randomPair.Value;

        return Tuple.Create(key, value);

    }
    

    
    
    
}