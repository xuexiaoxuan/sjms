using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 方法模板
{
    class ConcreteClassB : AbsstractClass
    {
        public override void PrimitveOperation1()
        {
            Console.WriteLine("具体类B方法实现1");
        }

        public override void PrimitveOperation2()
        {
            Console.WriteLine("具体类B方法实现2");
        }
    }
}
