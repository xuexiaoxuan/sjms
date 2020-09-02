using System;
using System.Collections.Generic;
using System.Text;

namespace 桥接模式
{
    class HandsetBrandN : HandsetBrand
    {
        public override void Run()
        {
            soft.Run();
        }
    }
}
