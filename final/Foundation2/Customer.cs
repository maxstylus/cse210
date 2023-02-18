public class Customer
{
    
    private string _name = "";
    private string _fullAddress = "";

    private bool _isUSA;
    
    //private Address address;

    public Customer(string name, Address address)
    {
        _name = name;
        _fullAddress = address.getFullAddress();
        _isUSA = address.isUSA();
    }

    public bool isUSA()
    {
        return _isUSA;
    }

    public string getName()
    {
        return _name;
    }

    public string getFullAddress()
    {
        return _fullAddress;
    }
}