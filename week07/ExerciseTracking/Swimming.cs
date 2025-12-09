public class Swimming : Activity
{
    private double _laps;

    public Swimming(string date, double length, double laps) : base(date, length)
    {
        _laps = laps;
    }

    public override double Distance()
    {
        return (_laps * 50) / 1000;
    }

    public override double Speed()
    {
        return (Distance() / _length) * 60;
    }

    public override double Pace()
    {
        return _length / Distance();
    }
}