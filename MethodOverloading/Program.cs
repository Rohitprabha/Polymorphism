using System;

namespace MethodOverloading
{
    class Program
    {
        public static void Add(int x, int y)
        {
            Console.WriteLine(x + y);
        }
        public static void Add(int x, int y, int z)
        {
            Console.WriteLine(x + y + z);
        }
        public static void Add(double x, double y)
        {
            Console.WriteLine(x + y);
        }
        static void Main(string[] args)
        {
            Add(2, 3);
            Add(2, 3, 4);
            Add(3.2, 2.3);
            
        }
    }
}
