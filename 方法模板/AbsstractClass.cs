using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 方法模板
{
    abstract class AbsstractClass
    {
        public abstract void PrimitveOperation1();
        public abstract void PrimitveOperation2();
        public void TemplateMetod()
        {
            PrimitveOperation1();
            PrimitveOperation2();
            Console.WriteLine("");
        }
    }
}
