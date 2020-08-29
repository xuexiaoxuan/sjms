using System;

namespace 代理模式
{
    class Program
    {
        static void Main(string[] args)
        {
            ShoolGrirl jiaojiao = new ShoolGrirl();
            jiaojiao.Name = "李娇娇";
            Pursuit pursuit = new Pursuit(jiaojiao);
            pursuit.GiveDolls();
            pursuit.GiveFlowers();
            pursuit.GiveChocolate();
            Console.Read();
        }
    }
}
