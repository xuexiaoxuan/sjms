using System;

namespace 适配器模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Target target = new Adapter();
            target.Request();
            Console.Read();
        }
    }
}
