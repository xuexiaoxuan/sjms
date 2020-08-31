using System;

namespace 状态模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context(new ContextStateA());
            context.Request();
            context.Request();
            context.Request();
            context.Request();
            Console.Read();
        }
    }
}
