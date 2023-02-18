public class Event  
{
    protected string _eventTitle = "";
    protected string _description = "";
    protected string _date = "";
    protected string _time = "";
    protected Address _eventAddress;

    public void setEventTitle(string eventTitle)
    {
        _eventTitle = eventTitle;
    }

    public void setDescription(string description)
    {
        _description = description;
    }

    public void setDate(string eventDate)
    {
        _date = eventDate;
    }

    public void setTime(string eventTime)
    {
        _time = eventTime;
    }

    public void setAddress(string street, string city, string state, string country)
    {
        _eventAddress = new Address(street, city, state, country);
    }

    public void displayStandardMessage()
    {
        Console.WriteLine($"Standard:\n------------\n{_eventTitle}\n{_description}\n{_date}\n{_time}\n{_eventAddress.getFullAddress()}");
    }

    public virtual void displayFullDetails()
    {
        //This method will be overridden by 3 derived classes. 
        Console.WriteLine($"Full:\n------------\n{_eventTitle}\n{_description}\n{_date}\n{_time}\n{_eventAddress.getFullAddress()}");
    }

    public void displayShortDescription()
    {
        // This method will be orverridden by 3 derived classes. They will each add their eventType
        Console.WriteLine($"Short:\n------------\n{_eventTitle}\n{_date}");
    }
}