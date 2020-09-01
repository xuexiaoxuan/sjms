using System;
using System.Collections.Generic;
using System.Text;

namespace 适配器模式
{
    public class Target
    {
        public virtual void Request()
        {
            Console.WriteLine("普通请求");
        }
    }
}
