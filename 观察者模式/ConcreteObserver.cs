using System;
using System.Collections.Generic;
using System.Text;

namespace 观察者模式
{
    class ConcreteObserver : Observer
    {
        private string name;
        private string observerState;
        public ConcreteSubject subject;
        public ConcreteObserver(ConcreteSubject subject,string name)
        {
            this.subject = subject;
            this.name = name;
        }
        public override void Update()
        {
            observerState = subject.SubjectState;
            Console.WriteLine("");
        }
        public ConcreteSubject Subject
        {
            get { return subject; }
            set { subject = value; }
        }
    }
}
