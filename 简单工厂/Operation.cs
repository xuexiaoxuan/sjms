using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 简单工厂
{
    public class Operation
    {
        public double NumberA = 0;
        public double NumberB = 0;
        public virtual double GetResult()
        {
            double restult = 0;
            return restult;
        }
    }
}
