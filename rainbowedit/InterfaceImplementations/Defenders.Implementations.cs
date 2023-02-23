using System.Collections;

namespace RainbowEdit;

/// <summary>
/// The <see cref="Defenders"/> in Siege.
/// </summary>
public sealed partial class Defenders : IEnumerable<Operator>, IEnumerator<Operator>
{
    private readonly List<Operator> _operators = new();

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
