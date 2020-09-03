using System;
using System.Collections.Generic;
using System.Text;

namespace 中介者模式
{
    class ConcreteMediator : Mediator
    {
        private ConcreteColleague1 colleague1;
        private ConcreteColleague2 colleague2;
        public ConcreteColleague1 Colleague1
        {
            set { colleague1 = value; }
        }
        public ConcreteColleague2 Colleague2
        {
            set { colleague2 = value; }
        }
        public override void Send(string message, Colleague colleageue)
        {
            if (colleageue == colleague1)
            {
                colleague2.Notify(message);
            }
            else
            {
                colleague1.Notify(message);

            }
        }
    }
}
