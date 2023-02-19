public class Running : Activity
{
    private string _activityType = "Running"; 
    private int _distance;

    public Running(int distance)
    {
        _distance = distance;
    }

    public override double getSpeed()
    {
        int intlength = getLength();
        double length = Convert.ToDouble(intlength);
        double distance = Convert.ToDouble(_distance);

        double speed = (distance / length) * 60;
        return speed;
    }

    public override double getPace()
    {
        return (getLength() / _distance);
    }
    
    public override string getSummary()
    {
        string summary = ($"{getDate()} {_activityType} ({getLength()} min) - Distance {_distance} miles, Speed {getSpeed()} mph, Pace: {getPace()} min per mile");
        return summary;

    }
}