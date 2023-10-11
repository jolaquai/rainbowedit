using System.Collections;

namespace rainbowedit;

/// <summary>
/// The <see cref="Attackers"/> in Siege.
/// </summary>
public sealed partial class Attackers : IEnumerable<Operator>
{
    private static readonly List<Operator> _operators = [];

    /// <summary>
    /// Returns a <see cref="List{T}"/> of all <see cref="Operator"/>s in the <see cref="Attackers"/> class.
    /// </summary>
    public static List<Operator> Operators => _operators.ToList();

    /// <inheritdoc/>
    public IEnumerator<Operator> GetEnumerator()
    {
        return ((IEnumerable<Operator>)_operators).GetEnumerator();
    }

    /// <inheritdoc/>
    IEnumerator IEnumerable.GetEnumerator()
    {
        return ((IEnumerable)_operators).GetEnumerator();
    }

    /// <inheritdoc/>
    public void Dispose()
    {
    }
}
