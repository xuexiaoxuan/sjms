using System;
using System.Collections.Generic;
using System.Text;

namespace 迭代器模式
{
    abstract class ITerator
    {
        public abstract object First();
        public abstract object Next();
        public abstract bool IsDone();
        public abstract object CurrentItem();
    }
}
