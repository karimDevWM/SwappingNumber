using System;

namespace SwappingNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number for n1 :");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter a number for n2 :");
            int n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("before");
            
            n1 = n1 + n2;
            n2 = n1 - n2;
            n1 = n1 - n2;

            Console.WriteLine("after");

            Console.WriteLine("n1 = "+n1);
            Console.WriteLine("n2 = "+n2);
        }
    }
}
