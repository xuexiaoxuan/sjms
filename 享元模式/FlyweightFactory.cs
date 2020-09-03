using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace 享元模式
{
    class FlyweightFactory
    {
        private Hashtable flyweights = new Hashtable();
        public FlyweightFactory()
        {
            flyweights.Add("X", new ConcreteFlyweight());
            flyweights.Add("Y", new ConcreteFlyweight());
            flyweights.Add("Z", new ConcreteFlyweight());
        }
        public Flyweight GetFlyweights(string key)
        {
            return (Flyweight)flyweights[key];
        }
    }
}
