using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 装饰模式
{
    class FineryB: Finery
    {
        public override void show()
        {
            Console.WriteLine("B");
            base.show();
        }
    }
}
