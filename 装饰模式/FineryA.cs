using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 装饰模式
{
    public class FineryA: Finery
    {
        public override void show()
        {
            Console.WriteLine("A");

            base.show();
        }
    }
}
