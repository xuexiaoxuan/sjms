using System;

namespace 简单工厂
{
    class Program
    {
        static void Main(string[] args)
        {
            Operation opre = OperationFactory.CreateOperate("+");
            opre.NumberA = 1;
            opre.NumberB = 2;
            Console.WriteLine(opre.GetResult());
        }
    }
}
