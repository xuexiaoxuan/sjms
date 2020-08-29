using System;

namespace 工厂方法
{
    class Program
    {
        static void Main(string[] args)
        {
            IFactory factory = new UndergraduateFactory();
            var leifeng= factory.CreateLeiFeng();
            leifeng.BuyRice();
            leifeng.Sweep();
            leifeng.Wash();
        }
    }
}
