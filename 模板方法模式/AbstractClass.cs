using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 模板方法模式
{
    abstract class AbstractClass
    {
        public abstract void PrimitivePperation1();
        public abstract void PrimitivePperation2();
        public void TemplateMethod()
        {
            PrimitivePperation1();
            PrimitivePperation2();
            Console.WriteLine("");
        }
    }
}
