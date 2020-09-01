using System;
using System.Collections.Generic;
using System.Text;

namespace 适配器模式
{
    public class Adaptee
    {
        public void SpecificRequest()
        {
            Console.WriteLine("特殊请求");
        }
    }
}
