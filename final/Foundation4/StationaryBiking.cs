public class StationaryBiking : Activity
{
    private string _activityType = "Cycling";
    
    private int _speed = 0;
    
    public StationaryBiking(int speed)
    {
        _speed = speed;
    }

    private double getDistance()
    {
        return (_speed / 60.0) * getLength();  // Convert _speed from mph to miles per minute
    }

    public override double getSpeed()
    {
        return ( getDistance() / getLength()) * 60;
    }

    public override double getPace()
    {
        return (getLength() / getDistance());
    }

   public override string getSummary()
    {
        string summary = ($"{getDate()} {_activityType} ({getLength()} min) - Distance {getDistance()} miles, Speed {_speed} mph, Pace: {getPace()} min per mile");
        return summary;
    }

}