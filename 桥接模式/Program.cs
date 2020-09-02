﻿using System;

namespace 桥接模式
{
    class Program
    {
        static void Main(string[] args)
        {
            HandsetBrand ab;
            ab = new HandsetBrandN();
            ab.SetHandsetSoft(new HandsetGame());
            ab.Run();
            ab.SetHandsetSoft(new HandsetAddressList());
            ab.Run();
            ab = new HandsetBrandM();
            ab.SetHandsetSoft(new HandsetGame());
            ab.Run();
            ab.SetHandsetSoft(new HandsetAddressList());
            ab.Run();
            Console.Read();
        }
    }
}
