using System;

namespace 享元模式
{
    class Program
    {
        static void Main(string[] args)
        {
            int extrinsicstate = 22;
            FlyweightFactory f = new FlyweightFactory();
            Flyweight fx = f.GetFlyweights("X");
            fx.Operation(--extrinsicstate);
            Flyweight fy = f.GetFlyweights("Y");
            fy.Operation(--extrinsicstate);
            Flyweight fz = f.GetFlyweights("Z");
            fz.Operation(--extrinsicstate);
            UnsharedConcreteFlyweight uf = new UnsharedConcreteFlyweight();
            uf.Operation(--extrinsicstate);
            Console.Read();
        }
    }
}
