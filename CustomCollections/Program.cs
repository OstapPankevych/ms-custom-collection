using System;

namespace CustomCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new MyList<int>();
            Console.WriteLine(list.Count);
            list.Add(5);
            list.Add(8);
            list.Add(7);
            list.Add(3);
            list.Add(8);
            list.Add(5);
            list.Add(15);
            list.Add(11);
            list.Add(1);
            list.Add(14);
            list.Add(29);
            list.Add(33);
            list.Add(47);
            list.Add(85);
            list.Add(63);
            list.Add(98);
            list.Add(89);
            list.Add(58);
            list.Add(85);
            list.Add(25);
            list.Add(52);
            list.Add(32);
            Console.WriteLine(list.Count);

            foreach (var x in list)
            {
                Console.WriteLine(string.Format("x = {0}", x));
            }

            list.Remove(8);
            Console.WriteLine(list.Count);

            foreach (var x in list)
            {
                Console.WriteLine(string.Format("x = {0}", x));
            }

            list.Clear();
            Console.WriteLine(list.Count);

            Console.ReadLine();
        }
    }
}
