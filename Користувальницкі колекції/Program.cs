using System.Collections;

namespace Користувальницкі_колекції;

internal class Program
{
    private static void Main(string[] args)
    {
        //ElementRealization();

        var collection = new MonthCollection();

        collection[0] = new Month("January", 0, 31);
        collection[1] = new Month("February", 1, 28);
        collection[2] = new Month("March", 2, 31);
        collection[3] = new Month("April", 3, 30);
        collection[4] = new Month("May", 4, 31);
        collection[5] = new Month("June", 5, 30);
        collection[6] = new Month("July", 6, 31);
        collection[7] = new Month("August", 7, 31);
        collection[8] = new Month("September", 8, 30);
        collection[9] = new Month("October", 9, 31);
        collection[10] = new Month("November", 10, 30);
        collection[11] = new Month("December", 11, 31);


        foreach (Month month in collection)
        {
            if(month.NumberOfDays == 31)
                Console.WriteLine(month.MonthName + " Days: " + month.NumberOfDays);
        }

        var monthByOder = collection.GetMonthByOrder(3);
        Console.WriteLine(monthByOder.MonthName + " Days: " + monthByOder.NumberOfDays);
        

        Console.ReadKey();
    }


    static void ElementRealization()
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
    }
}