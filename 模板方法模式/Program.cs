using System;

namespace 模板方法模式
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractClass c;
            c = new ConcreteClassA();
            c.TemplateMethod();
            c = new ConcreteClassB();
            c.TemplateMethod();
            Console.Read();
         }
    }
}
