using System.Collections;

namespace Користувальницкі_колекції;

public class MonthCollection : IEnumerator, IEnumerable
{
    private readonly Month[] _months = new Month[12];
    public int position = -1;
    
    public Month this[int index]
    {
        get { return _months[index]; }
        set { _months[index] = value; }
    }
    
    public bool MoveNext()
    {
        if (position < _months.Length - 1)
        {
            position++;
            return true;
        }
        Reset();
        return false;
    }

    public void Reset() => position = -1;

    public object Current => _months[position];

    public IEnumerator GetEnumerator() => this;

    public Month? GetMonthByOrder(int order) => _months.FirstOrDefault(m => m.Index == order);
    public IEnumerable<Month> GetMonthsByDays(uint days) => _months.Where(m => m.NumberOfDays == days);
}