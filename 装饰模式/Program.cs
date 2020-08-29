using System;

namespace 装饰模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            FineryA fineryA = new FineryA();
            FineryB fineryB = new FineryB();
            fineryA.Dice(p);
            fineryB.Dice(fineryA);
            fineryB.show();
        }
    }
}
