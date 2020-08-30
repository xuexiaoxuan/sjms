using System;

namespace 方法模板
{
    class Program
    {
        static void Main(string[] args)
        {
            AbsstractClass c;
            c = new ConcreteClassA();
            c.TemplateMetod();
            c = new ConcreteClassB();
            c.TemplateMetod();
        }
    }
}
