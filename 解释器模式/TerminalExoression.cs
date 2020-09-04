using System;
using System.Collections.Generic;
using System.Text;

namespace 解释器模式
{
    class TerminalExoression : AbstractExperssion
    {
        public override void Interpret(Context context)
        {
            Console.WriteLine("终端解释器");
        }
    }
}
