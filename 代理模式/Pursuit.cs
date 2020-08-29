using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 代理模式
{
    class Pursuit : IGiveGift
    {
        ShoolGrirl mm;
        public Pursuit(ShoolGrirl mm)
        {
            this.mm = mm;
        }
        public void GiveChocolate()
        {
            Console.WriteLine("GiveChocolate");
        }

        public void GiveDolls()
        {
            Console.WriteLine("GiveDolls");
        }

        public void GiveFlowers()
        {
            Console.WriteLine("GiveFlowers");
        }
    }
}
