using System;
using System.Collections.Generic;
using System.Text;

namespace 中介者模式
{
    public abstract class Mediator
    {
        public abstract void Send(string message, Colleague colleageue);
    }
}
