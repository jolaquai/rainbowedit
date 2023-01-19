using System.Collections;

namespace RainbowEdit;

public sealed partial class Attackers : IEnumerable<Operator>, IEnumerator<Operator>
{
    private readonly List<Operator> _operators = new();

    public IEnumerator<Operator> GetEnumerator()
    {
        return ((IEnumerable<Operator>)_operators).GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return ((IEnumerable)_operators).GetEnumerator();
    }

    public bool MoveNext()
    {
        if (_pointer + 1 < _operators.Count)
        {
            _pointer++;
            return true;
        }
        return false;
    }

    public void Reset()
    {
        _pointer = 0;
    }

    public void Dispose()
    {
    }

    private int _pointer = 0;

    public Operator Current => _operators[_pointer];

    object IEnumerator.Current => Current;
}
