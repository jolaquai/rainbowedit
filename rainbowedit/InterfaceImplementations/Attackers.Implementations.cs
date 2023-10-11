using System.Collections;

namespace rainbowedit;

/// <summary>
/// The <see cref="Attackers"/> in Siege.
/// </summary>
public sealed partial class Attackers : IEnumerable<Operator>, IEnumerator<Operator>
{
    private static readonly List<Operator> _operators = new();

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
    public bool MoveNext()
    {
        if (_pointer + 1 < _operators.Count)
        {
            _pointer++;
            return true;
        }
        return false;
    }

    /// <inheritdoc/>
    public void Reset()
    {
        _pointer = 0;
    }

    /// <inheritdoc/>
    public void Dispose()
    {
    }

    private int _pointer = 0;

    /// <inheritdoc/>
    public Operator Current => _operators[_pointer];

    /// <inheritdoc/>
    object IEnumerator.Current => Current;
}
