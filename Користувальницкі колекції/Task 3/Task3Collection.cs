using System.Collections;

namespace Користувальницкі_колекції.Task_3;

public class Task3Collection : IEnumerator, IEnumerable
{
    private readonly Citizen[] _citizenCollection = new Citizen[30];
    public int position = -1;
    
    public Citizen this[int index]
    {
        get { return _citizenCollection[index]; }
        set { _citizenCollection[index] = value; }
    }
    
    public bool MoveNext()
    {
        if (position < _citizenCollection.Length - 1)
        {
            position++;
            return true;
        }
        Reset();
        return false;
    }

    public void Reset() => position = -1;

    public object Current => _citizenCollection[position];

    public IEnumerator GetEnumerator() => this;
}