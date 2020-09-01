using System;
using System.Collections.Generic;
using System.Text;

namespace 组合模式
{
    abstract class Component
    {
        public string Name { get; set; }
        public Component(string name)
        {
            this.Name = name;
        }
        
        public abstract void Add(Component c);
        public abstract void Remove(Component c);
        public abstract void Display(int depth);
    }
}
