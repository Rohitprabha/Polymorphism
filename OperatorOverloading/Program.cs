using System;

namespace Compile_Time_Polymorphism_2
{
    class OperatorOverloading
    {
        int x, y, z;
        public OperatorOverloading(int a, int b, int c)
        {
            x = a;
            y = b;
            z = c;
        }
        public void Display()
        {
            Console.WriteLine(x + " " + y + " " + z);
        }
        public static OperatorOverloading operator-(OperatorOverloading obj)
        {
            obj.x = -obj.x;
            obj.y = -obj.y;
            obj.z = -obj.z;
            return obj;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            OperatorOverloading obj = new OperatorOverloading(-10,-20,30);
            obj.Display();
            obj = -obj;
            obj.Display();
        }
    }
}
