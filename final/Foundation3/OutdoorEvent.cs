public class OutdoorEvent : Event
{
    private string _weatherForecast = "not provided";

    public OutdoorEvent(string weatherForecast)
    {
        _weatherForecast = weatherForecast;
    }

    public override void displayFullDetails()
    {
        //This method will be overridden by 3 derived classes. 
        Console.WriteLine($"Full:\n------------\n{_eventTitle}\n{_description}\n{_weatherForecast}\n{_date}\n{_time}\n{_eventAddress.getFullAddress()}");
    }

}