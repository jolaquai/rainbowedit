namespace rainbowedit;

/// <summary>
/// Represents the age of an <see cref="Operator"/>.
/// </summary>
public class OperatorAge
{
    /// <summary>
    /// The day of birth of the <see cref="Operator"/>.
    /// </summary>
    public int Day { get; }
    /// <summary>
    /// The month of birth of the <see cref="Operator"/>.
    /// </summary>
    public int Month { get; }
    /// <summary>
    /// The age of the <see cref="Operator"/>.
    /// </summary>
    public int Age { get; }

    /// <summary>
    /// Instantiates an <see cref="OperatorAge"/> instance for the given data.
    /// </summary>
    /// <param name="day">The day of birth of the <see cref="Operator"/>.</param>
    /// <param name="month">The month of birth of the <see cref="Operator"/>.</param>
    /// <param name="age">The age of the <see cref="Operator"/>.</param>
    internal OperatorAge(int day, int month, int age)
    {
        Day = day;
        Month = month;
        Age = age;
    }

    /// <summary>
    /// Constructs a <see cref="DateTime"/> instance representing the current date of birth of the <see cref="Operator"/>.
    /// </summary>
    public DateTime ToDateTime() => new DateTime(DateTime.Now.AddYears(-Age).Year, Month, Day);

    /// <summary>
    /// Represents an <see cref="Operator"/>'s age when it is "redacted" or unavailable in-game for any other reason.
    /// </summary>
    public static readonly OperatorAge Redacted = new OperatorAge(-1, -1, -1);
}
