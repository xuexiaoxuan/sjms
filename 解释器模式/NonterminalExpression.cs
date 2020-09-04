using System;
using System.Collections.Generic;
using System.Text;

namespace 解释器模式
{
    class NonterminalExpression : AbstractExperssion
    {
        public override void Interpret(Context context)
        {
            Console.WriteLine("非终端解释器");
        }
    }
}
