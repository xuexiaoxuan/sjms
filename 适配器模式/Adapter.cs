using System;
using System.Collections.Generic;
using System.Text;

namespace 适配器模式
{
    class Adapter:Target
    {
        public Adaptee adaptee = new Adaptee();
        public override void Request()
        {
            adaptee.SpecificRequest();
        }
    }
}
