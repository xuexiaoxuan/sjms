using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 策略模式
{
   public class Context
    {
        public Strategy strategy;
        public Context(string type)
        {
            strategy = type switch
            {
                "A" => new ConcreteStrategyA(),
                "B" => new ConcreteStrategyB(),
                _ => throw new NotImplementedException()
            };
         }

        public void ContextInterface()
        {
            strategy.AlgorithmInterface();
        }
    }
}
