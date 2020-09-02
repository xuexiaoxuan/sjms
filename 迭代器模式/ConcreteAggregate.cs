﻿using System;
using System.Collections.Generic;
using System.Text;

namespace 迭代器模式
{
    class ConcreteAggregate : Aggregate
    {
        private IList<object> items = new List<object>();
        public override ITerator CreateIterator()
        {
            return new ConcreteIterator(this);
        }
        public int Count
        {
            get { return items.Count; }
        }
        public object this[int index]
        {
            get { return items[index]; }
            set { items.Insert(index, value); }
        }
    }
}
