using System;
using System.Collections.Generic;
using System.Text;

namespace 状态模式
{
    class ContextStateA : State
    {
        public override void Handle(Context context)
        {
            context.States = new ContextStateA();
        }
    }
}
