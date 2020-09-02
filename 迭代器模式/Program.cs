using System;

namespace 迭代器模式
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteAggregate a = new ConcreteAggregate();
            a[0] = "a";
            a[1] = "b";
            a[2] = "c";
            a[3] = "d";
            ITerator i = new ConcreteIterator(a);
            object item = i.First();
            while (!i.IsDone())
            {
                Console.WriteLine("{0}请买车票", i.CurrentItem());
                i.Next();
            }
            Console.Read();
        }
    }
}
