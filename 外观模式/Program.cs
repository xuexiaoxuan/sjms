﻿using System;

namespace 外观模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Facade facade = new Facade();
            facade.MethodA();
            facade.MethodB();
            Console.Read();
        }
    }
}
