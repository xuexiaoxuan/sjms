﻿using System;
using System.Collections.Generic;
using System.Text;

namespace 享元模式
{
    class ConcreteFlyweight : Flyweight
    {
        public override void Operation(int extrinsicstate)
        {
            Console.WriteLine("具体Flyweight:" + extrinsicstate);
        }
    }
}
