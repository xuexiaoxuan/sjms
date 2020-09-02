using System;
using System.Collections.Generic;
using System.Text;

namespace 桥接模式
{
    class HandsetGame : HandsetSoft
    {
        public override void Run()
        {
            Console.WriteLine("运行手机游戏");
        }
    }
}
