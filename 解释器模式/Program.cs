using System;
using System.Collections;
using System.Collections.Generic;

namespace 解释器模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context();
            IList<AbstractExperssion> list = new List<AbstractExperssion>();
            list.Add(new TerminalExoression());
            list.Add(new NonterminalExpression());
            list.Add(new TerminalExoression());
            list.Add(new TerminalExoression());
            foreach(AbstractExperssion exp in list)
            {
                exp.Interpret(context);
            }
            Console.Read();
        }
    }
}
