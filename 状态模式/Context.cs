using System;
using System.Collections.Generic;
using System.Text;

namespace 状态模式
{
    class Context
    {
        private State state { get; set; }
        public Context(State state)
        {
            this.state = state;
        }
        public State States{
            get { return state; }
            set
            {
                state = value;
                Console.WriteLine("当前状态:" + state.GetType().Name);
            }
            }
        public void Request()
        {
            state.Handle(this);
        }
    }
}
