namespace rainbowedit.Exceptions;

/// <summary>
/// The exception that is thrown when any part of a loadout is attempted to be brought in connection with an <see cref="rainbowedit.Operator"/> that it does not match with inside a <see cref="LoadoutConfiguration"/>.
/// </summary>
internal class LoadoutOperatorMismatchException : Exception
{
    /// <summary>
    /// The <see cref="rainbowedit.Operator"/> that was targeted.
    /// </summary>
    public Operator Operator { get; }
    /// <summary>
    /// The type of the <see cref="Value"/> that was attempted to be brought in connection with <see cref="Operator"/>.
    /// </summary>
    public Type Type { get; }
    /// <summary>
    /// The erroneous value of Type <see cref="Type"/> that was attempted to be brought in connection with <see cref="Operator"/>.
    /// </summary>
    public object Value { get; }

    /// <summary>
    /// Instantiates a new <see cref="LoadoutOperatorMismatchException"/> with a given <paramref name="operator"/> and <paramref name="value"/>.
    /// </summary>
    /// <param name="value">The value that was attempted to be brought in connection with <paramref name="operator"/>.</param>
    /// <param name="operator">The <see cref="rainbowedit.Operator"/> that was targeted despite the <paramref name="value"/> not belonging to them.</param>
    public LoadoutOperatorMismatchException(Operator @operator, object value)
    {
        Operator = @operator;
        Type = value.GetType();
        Value = value;
    }
}
