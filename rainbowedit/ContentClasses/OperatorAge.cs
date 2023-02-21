namespace RainbowEdit;

public class OperatorAge
{
    public int Day { get; private set; }
    public int Month { get; private set; }
    public int Age { get; private set; }

    internal OperatorAge(int day, int month, int age)
    {
        Day = day;
        Month = month;
        Age = age;
    }

    public DateTime ToDateTime() => new(DateTime.Now.Year - Age, Month, Day);

    public static readonly OperatorAge Redacted = new(-1, -1, -1);
}
