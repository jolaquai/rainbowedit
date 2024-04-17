namespace rainbowedit.Exceptions;

/// <summary>
/// The exception that is thrown when an enum value is attempted to be represented by a string that does not match it inside a <see cref="WeaponConfiguration"/>.
/// </summary>
internal class EnumStringificationException<TEnum> : Exception
{
    public TEnum? Enum { get; }
    public string String { get; }

    /// <summary>
    /// Initializes a new <see cref="EnumStringificationException{TEnum}"/> with a given <typeparamref name="TEnum"/> and <paramref name="string"/>.
    /// </summary>
    /// <param name="enum">The enum value of type <typeparamref name="TEnum"/> that was attempted to be represented by <paramref name="string"/>.</param>
    /// <param name="string">The string representation that did not match the actual value of <paramref name="enum"/>.</param>
    public EnumStringificationException(TEnum @enum, string @string)
    {
        Enum = @enum;
        String = @string;
    }
    
    /// <summary>
    /// Initializes a new <see cref="EnumStringificationException{TEnum}"/> with a given <paramref name="string"/>.
    /// </summary>
    /// <param name="string">The string representation that did not match any actual value <typeparamref name="TEnum"/> can have.</param>
    public EnumStringificationException(string @string)
    {
        String = @string;
    }
}
