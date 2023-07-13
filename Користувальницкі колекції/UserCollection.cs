using System.Collections;

namespace Користувальницкі_колекції;

// Класс, представляющий собой пользовательскую коллекцию
public class UserCollection<T> : IEnumerable<T>, IEnumerator<T>
{
    private readonly T[] elements = new T[4];

    public T this[int index]
    {
        get { return elements[index]; }
        set { elements[index] = value; }
    }

    public int position = -1;
    
    public IEnumerator<T> GetEnumerator() => (IEnumerator<T>)this;

    bool IEnumerator.MoveNext()
    {
        if (position < elements.Length - 1)
        {
            position++;
            return true;
        }
        return false;
    }

    public object Current => elements[position] ?? throw new InvalidOperationException();
    
    T IEnumerator<T>.Current => elements[position];

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this;
    }

    void IEnumerator.Reset()
    {
        position = -1;
    }

    void IDisposable.Dispose()
    {
        ((IEnumerator)this).Reset();
    }
}