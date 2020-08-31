using System;
using System.Collections.Generic;
using System.Text;

namespace 状态模式
{
    abstract class State
    {
        public abstract void Handle(Context context);
    }
}
