using System;

namespace 访问者模式
{
    class Program
    {
        static void Main(string[] args)
        {
            ObjectStructure o = new ObjectStructure();
            o.Attach(new Man());
            o.Attach(new Woman());
            Success vl = new Success();
            o.Display(vl);
            
        }
    }
}
