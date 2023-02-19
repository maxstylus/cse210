public class Activity
{
    private string _date = "";
    private int _length = 0;

    public void setDate(string date)
    {
        _date = date;
    }

    public string getDate()
    {
        return _date;
    }

    public void setLength(int length)
    {
        _length = length;
    }

    public int getLength()
    {
        return _length;
    }

    public virtual double getSpeed()
    {
        return 0.0; //( _distance / getLength()) * 60;
    }

    public virtual double getPace()
    {
        return 0.0; // (getLength() / _speed);
    }

    public virtual double getDistance()
    {
        return 0.0; 
    }

    public virtual string getSummary()
    {
        return "This is the base class: Activity summary";
    }

}