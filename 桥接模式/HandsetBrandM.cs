using System;
using System.Collections.Generic;
using System.Text;

namespace 桥接模式
{
    class HandsetBrandM : HandsetBrand
    {
        public override void Run()
        {
            soft.Run();
        }
    }
}
