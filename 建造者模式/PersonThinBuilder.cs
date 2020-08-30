using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 建造者模式
{
    class PersonThinBuilder : PersonBuilder
    {
        public PersonThinBuilder(Graphics g,Pen p) : base(g, p) { }
        public override void BuildArmLeft()
        {
            throw new NotImplementedException();
        }

        public override void BuildArmRight()
        {
            throw new NotImplementedException();
        }

        public override void BuildBody()
        {
            throw new NotImplementedException();
        }

        public override void BuildHead()
        {
            throw new NotImplementedException();
        }

        public override void BuildLegLeft()
        {
            throw new NotImplementedException();
        }

        public override void BuildLegRight()
        {
            throw new NotImplementedException();
        }
    }
}
