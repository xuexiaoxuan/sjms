using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 装饰模式
{
    public class Finery : Person
    {
        public Person Person;
        public void Dice(Person Person)
        {
            this.Person = Person;
        }
        public override void show()
        {
            if (Person != null)
            {
                Person.show();
            }
        }
    }
}
