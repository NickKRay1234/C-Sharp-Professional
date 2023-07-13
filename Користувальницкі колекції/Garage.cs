using System.Collections;

namespace Користувальницкі_колекції;

public class Garage : IEnumerable
{
    private Car[] carArray = new Car[4];


    public IEnumerator GetEnumerator()
    {
        throw new Exception("This won't get called");
        foreach (Car car in carArray)
        {
            yield return car;
        }
    }
}