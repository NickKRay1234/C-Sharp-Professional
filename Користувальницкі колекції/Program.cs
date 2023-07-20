using System.Collections;
using Користувальницкі_колекції;

namespace Collection;

internal class Program
{
    public class DescendingComparer : IComparer
    {
        private CaseInsensitiveComparer _comparer = new CaseInsensitiveComparer();

        public int Compare(object? x, object? y)
        {
            int result = _comparer.Compare(y, x);
            return result;
        }
    }

    class MyClass
        {

        }


        static int Add(int x, int y)
        {
            Console.WriteLine("Add() invoked on thread {0}.", Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(5000);
            return x + y;
        }

        public delegate int BinaryOp(int x, int y);

        static void PrintTime(object state)
        {
            Console.WriteLine("Time is: {0}, Param is: {1}", DateTime.Now.ToLongTimeString(), state.ToString());
        }

        public class MyClass2
        {
            ~MyClass2()
            {
                Console.WriteLine("Hello Destructor");
            }
        }
        
        static void Main()
        {
            MyClass2 my = new MyClass2();




            // Console.WriteLine("**** Working with Timer type ****\n");
            // TimerCallback timeCB = new TimerCallback(PrintTime);
            // Timer t = new Timer(timeCB, "Hello From Main", 0, 1000);
            // Console.WriteLine("Hit key to terminate");
            // Console.ReadLine();


            // Console.WriteLine("**** Async Delegate Invocation ****");
            // Console.WriteLine("Main() invoked on thread {0}", Thread.CurrentThread.ManagedThreadId);
            // BinaryOp b = Add;
            // IAsyncResult ar = b.BeginInvoke(10, 10, null, null);
            // while(!ar.IsCompleted) 
            //     Console.WriteLine("Doing more work in Main()!");
            //
            // int answer = b.EndInvoke(ar);
            // Console.WriteLine("10 + 10 is {0}.", answer);
            // Console.ReadLine();



            // MyClass my = new MyClass();
            // Type type;
            //
            // type = my.GetType();
            // Console.WriteLine("1st: " + type);
            //
            // // type = Type.GetType("Користувальницкі_колекції.MyClass");
            // // Console.WriteLine("2st: " + type);
            //
            // type = typeof(MyClass);
            // Console.WriteLine("3st: " + type);
            //
            //
            // BitArray bits = new BitArray(8);
            // bits[0] = false;
            // bits[1] = true;
            // bits[2] = false;
            // Console.WriteLine(bits.Length);







            // var sort = new SortedList(new DescendingComparer());
            //
            // sort["First"] = "1st";
            // sort["Second"] = "2nd";
            // sort["Third"] = "3rd";
            // sort["Fourth"] = "4th";
            // sort["fourth"] = "44th";
            //
            // foreach (DictionaryEntry entry in sort)
            // {
            //     Console.WriteLine("{0} == {1}", entry.Key, entry.Value);
            // }
            //
            //
            //
            //
            //
            //
            //
            //
            //
            //
            //
            // var emailLookUp = new Hashtable();
            //
            // emailLookUp.Add("kolya.kalchuk@gmail.com", "Mykola, Kalchuk");
            // // Невозможно добавить элемент с уже имеющимся в хэш-таблице ключом.
            // //emailLookUp.Add("kolya.kalchuk@gmail.com", "Mykola, Kalchuk");
            //
            // emailLookUp["denysenko@gmail.com"] = "Eliza, Denysenko";
            // emailLookUp["kalchuk@gmail.com"] = "Sergii, Kalchuk";
            // emailLookUp["Lkalchuk2008@ukr.net"] = "Olena, Kalchuk";

            // foreach (object name in emailLookUp)
            // {
            //     Console.WriteLine(name);
            // }
            //
            // Console.WriteLine(new string('-', 20));
            //
            // foreach (DictionaryEntry name in emailLookUp)
            // {
            //     Console.WriteLine(name.Value);
            // }
            //
            // Console.WriteLine(new string('-', 20));
            //
            // foreach (object name in emailLookUp.Keys)
            // {
            //     Console.WriteLine(name);
            // }








            // var queue = new Queue();
            // queue.Enqueue("An item"); // Добавлять элемент в конец очереди.
            // Console.WriteLine(queue.Dequeue()); // Возвращать первый элемент очереди, удаляя его. 
            //
            // var queue1 = new Queue();
            // queue.Enqueue("First");
            // queue.Enqueue("Second");
            // queue.Enqueue("Third");
            // queue.Enqueue("Fourth");
            //
            // object element = queue.Peek();
            // Console.WriteLine(element as string);



            //ElementRealization();
            //MonthRealization();
            //ArrayListTest();

            //var collection = new Task3Collection();

            //collection[0] = new 

            // foreach (int i in ProduceEvenNumbers(9))
            // {
            //     Console.Write(i);
            //     Console.Write(" ");
            // }
            //
            // IEnumerable<int> ProduceEvenNumbers(int upto)
            // {
            //     for (int i = 0; i <= upto; i += 2)
            //         yield return i;
            // }
        }


        static void ArrayListTest()
        {
            var list = new ArrayList();

            string s = "Hello";
            list.Add(s);
            list.Add("hello");
            list.Add(50);
            list.Add(new object());

            var anArray = new[] { "more", "or", "less" };
            list.AddRange(anArray);

            var anotherArray = new[] { new object(), new ArrayList() };
            list.AddRange(anotherArray);

            list.Insert(3, "Hey All");

            var moreString = new[] { "goodnight", "see ya" };
            list.InsertRange(4, moreString);
        }

        static void MonthRealization()
        {
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
                if (month.NumberOfDays == 31)
                    Console.WriteLine(month.MonthName + " Days: " + month.NumberOfDays);
            }

            var monthByOder = collection.GetMonthByOrder(3);
            Console.WriteLine(monthByOder.MonthName + " Days: " + monthByOder.NumberOfDays);
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