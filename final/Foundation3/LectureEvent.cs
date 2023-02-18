public class LectureEvent : Event

{
    private string _speakerName = "";
    private int _peopleCapacity = 0;

    public LectureEvent(string speakerName, int peopleCapacity)
    {
        _speakerName = speakerName;
        _peopleCapacity = peopleCapacity;
    }

    
    public override void displayFullDetails()
    {
        //This method will be overridden by 3 derived classes. 
        Console.WriteLine($"Full:\n------------\n{_eventTitle}\n{_description}\n{_speakerName}\n{_peopleCapacity}\n{_date}\n{_time}\n{_eventAddress.getFullAddress()}");
    }


}