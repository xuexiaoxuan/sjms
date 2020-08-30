using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 模板方法模式
{
    class ConcreteClassA : AbstractClass
    {
        public override void PrimitivePperation1()
        {
            Console.WriteLine("具体类A方法实现1");
        }

        public override void PrimitivePperation2()
        {
            Console.WriteLine("具体类A方法实现2");
        }
    }
}
