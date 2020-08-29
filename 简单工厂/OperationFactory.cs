using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 简单工厂
{
    class OperationFactory
    {
        public static Operation CreateOperate(string operate)=>
            operate switch
            {
                "+" => new OperationAdd(),
                "-" => new OperationSub(),
                _ => throw new NotImplementedException(),
            };
           
        
    }
}
