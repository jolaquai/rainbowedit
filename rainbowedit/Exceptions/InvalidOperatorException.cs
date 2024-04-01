namespace rainbowedit.Exceptions;

/// <summary>
/// The exception that is thrown when an attempt is made to instantiate or retrieve an invalid <see cref="Operator"/> instance.
/// </summary>
internal class InvalidOperatorException : Exception
{
    public InvalidOperatorException(string reasonPhrase) : base(reasonPhrase) { }
    public InvalidOperatorException(string operatorName, string reasonPhrase) : base($"An attempt was made to instantiate, retrieve or access an offending property of Operator '{operatorName}', which resulted in an invalid state: '{reasonPhrase}'") { }
}
