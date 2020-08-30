using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 模板方法模式
{
    class ConcreteClassB : AbstractClass
    {
        public override void PrimitivePperation1()
        {
            Console.WriteLine("具体类B方法实现1");
        }

        public override void PrimitivePperation2()
        {
            Console.WriteLine("具体类B方法实现2");
        }
    }
}
