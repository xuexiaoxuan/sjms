using System;

namespace 建造者模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Pen p = new Pen();
            PersonThinBuilder pth = new PersonThinBuilder(new Graphics(), p);
            PersonDirector pdThin = new PersonDirector(pth);
            pdThin.CreatePerson();
        }
    }
}
