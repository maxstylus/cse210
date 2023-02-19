public class SwimmingLapPool : Activity
{
    private string _activityType = "Swimming";
    private int _numLaps = 0;

    public SwimmingLapPool(int numLaps)
    {
        _numLaps = numLaps;
    }

    private double getDistance()
    {
        return ((_numLaps * 50) / 1000) * 0.62;
    }

    public override double getSpeed()
    {
        return Math.Round((getDistance() / getLength()) * 60, 2);
    }

    public override double getPace()
    {
        return Math.Round((getLength() / getDistance()), 2);
    }

   public override string getSummary()
    {
        string summary = ($"{getDate()} {_activityType} ({getLength()} min) - Distance {getDistance()} miles, Speed {getSpeed()} mph, Pace: {getPace()} min per mile");
        return summary;
    }
}