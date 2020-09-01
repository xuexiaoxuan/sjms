using System;
using System.Collections.Generic;
using System.Text;

namespace 组合模式
{
    class Leaf : Component
    {
        public Leaf(string name) : base(name)
        {

        }
        public override void Add(Component c)
        {
            Console.WriteLine("");
        }

        public override void Display(int depth)
        {
            Console.WriteLine("");
        }

        public override void Remove(Component c)
        {
            Console.WriteLine("");
        }
    }
}
