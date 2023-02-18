
public class ReceptionEvent : Event
{
    private string _email = "not provided";

    public ReceptionEvent(string email)
    {
        _email = email;
    }

    public override void displayFullDetails()
    {
        //This method will be overridden by 3 derived classes. 
        Console.WriteLine($"Full:\n------------\n{_eventTitle}\n{_description}\n{_date}\n{_time}\n{_email}\n{_eventAddress.getFullAddress()}");
    }

}