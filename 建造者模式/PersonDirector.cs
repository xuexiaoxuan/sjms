using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 建造者模式
{
    class PersonDirector
    {
        public PersonBuilder pd;
        public PersonDirector(PersonBuilder pd)
        {
            this.pd = pd;
        }
        public void CreatePerson()
        {
            pd.BuildHead();
            pd.BuildBody();
            pd.BuildArmLeft();
            pd.BuildArmRight();
            pd.BuildLegLeft();
            pd.BuildLegRight();
        }
    }
}
