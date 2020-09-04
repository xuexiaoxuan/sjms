using System;
using System.Collections.Generic;
using System.Text;

namespace 解释器模式
{
    abstract class AbstractExperssion
    {
        public abstract void Interpret(Context context);
    }
}
