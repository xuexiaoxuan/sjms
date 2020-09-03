using System;
using System.Collections.Generic;
using System.Text;

namespace 职责链模式
{
    abstract class Handler
    {
        protected Handler successor;
        public void SetSuccessor(Handler successor)
        {
            this.successor = successor;
        }
        public void HandleRequest(int request)
        {
            if (BoolIs(request))
            {
                Console.WriteLine("{0}处理请求{1}", this.GetType().Name, request);
            }
            else if (successor != null)
            {
                successor.HandleRequest(request);
            }
        }
        public abstract bool BoolIs(int request);
        //public abstract void HandleRequest(int request);
    }
}
