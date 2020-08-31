using System;
using System.Collections.Generic;
using System.Text;

namespace 状态模式
{
    class ContextStateB : State
    {
        public override void Handle(Context context)
        {
            context.States = new ContextStateB();
        }
    }
}
