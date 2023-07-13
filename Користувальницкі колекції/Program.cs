using System.Collections;

namespace Користувальницкі_колекції;

internal class Program
{
    private static void Main(string[] args)
    {
        var collection = new UserCollection<Element>();

        collection[0] = new Element(1, 2);
        collection[1] = new Element(3, 4);
        collection[2] = new Element(5, 6);
        collection[3] = new Element(7, 8);

        foreach (Element element in collection)
            Console.WriteLine("{0}, {1}", element.FieldA, element.FieldB);

        IEnumerator enumerator = (collection as IEnumerable).GetEnumerator();
        while (enumerator.MoveNext())
        {
            Element? element = enumerator.Current as Element;
            if (element != null) Console.WriteLine("{0}, {1}", element.FieldA, element.FieldB);
        }

        Console.ReadKey();
    }
}