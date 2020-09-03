using System;

namespace 中介者模式
{
    public class ConcreteColleague2 : Colleague
    {
        public ConcreteColleague2(Mediator mediator) : base(mediator)
        {

        }
        public void Send(string message)
        {
            mediator.Send(message, this);
        }
        public void Notify(string message)
        {
            Console.WriteLine("同事2得到消息:" + message);
        }
    }
}