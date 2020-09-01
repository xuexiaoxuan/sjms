﻿using System;

namespace 备忘录模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Originator o = new Originator();
            o.State = "On";
            o.Show();
            Caretaker c = new Caretaker();
            c.Memento = o.CreateMemento();
            o.State = "Off";
            o.Show();
            o.SetMemento(c.Memento);
            o.Show();
            Console.Read();
        }
    }
}
