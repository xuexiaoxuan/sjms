using System;
using System.Collections.Generic;
using System.Text;

namespace 迭代器模式
{
    abstract class Aggregate
    {
        public abstract ITerator CreateIterator();
    }
}
