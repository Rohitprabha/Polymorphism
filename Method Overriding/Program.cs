using System;

namespace Runtime_Polymorphism
{
    class Base
    {
        public virtual void print()
        {
            Console.WriteLine("Base class print");
        }
    }
    class Derived : Base
    {
        public override void print()
        {
            base.print();
            Console.WriteLine("Derived class print");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Derived d = new Derived();
            d.print();
        }
    }
}
