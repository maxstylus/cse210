
public static class PromptGenerator
{
    public static string getRandomPrompt()
    {
            
        List<string> journalPrompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?", 
            "What was a lesson learnt today?", 
            "Who did I help today?"
        };  
        
        var random = new Random();
        int index = random.Next(journalPrompts.Count);
        string prompt = journalPrompts[index];

        return prompt;       
        
    } 

    public static string getUpliftingMessage()
    {
            
        List<string> upliftingMessages = new List<string>
        {
            "Nothing is impossible. The word itself says, I'm possible! — Audrey Hepburn ",
            "Fall seven times, stand up eight. - Japanese Proverb.",
            "The most effective way to do it, is to do it. - Amelia Earhart", 
            "It is during our darkest moments that we must focus to see the light. - Aristotle Onassis", 
            "No one can make you feel inferior without your consent. - Eleanor Roosevelt", 
            "It always seems impossible until it is done. - Nelson Mandela", 
            "Sometimes when you are in a dark place you think you have been buried, but actually you have been planted - Christine Caine", 
            "Remember, today is the tomorrow you worried about yesterday. - Dale Carnegie", 
            "Start where you are. Use what you have. Do what you can. - Arthur Ashe"
        };  
        
        var random = new Random();
        int index = random.Next(upliftingMessages.Count);
        string upliftingMessage = upliftingMessages[index];

        return upliftingMessage;       
        
    } 
     
}