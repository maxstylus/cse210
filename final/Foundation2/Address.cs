public class Address
{
    private string _street = "";
    private string _city = "";
    private string _state = "";
    private string _country = "";
    
    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public Boolean isUSA()
    {
        if (_country == "USA" || _country == "United States of America" || _country == "America")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public string getFullAddress()
    {
        return ($"\n{_street}\n{_city}\n{_state}\n{_country}\n");
    }
}