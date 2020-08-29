using System;

namespace 策略模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context("A");
            context.ContextInterface();
        }
    }
}
