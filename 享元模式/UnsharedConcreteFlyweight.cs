﻿using System;
using System.Collections.Generic;
using System.Text;

namespace 享元模式
{
    class UnsharedConcreteFlyweight : Flyweight
    {
        public override void Operation(int extrinsicstate)
        {
            Console.WriteLine("不共享具体Flyweight:" + extrinsicstate);
        }
    }
}
