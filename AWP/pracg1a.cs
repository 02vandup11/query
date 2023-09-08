using System;

namespace Practical1A
{
    class pracg1a
    {
        public static void Main()
        {
            int n1,n2,n3,n4,product;

            Console.WriteLine("Enter Four No : ");

            n1 = Convert.ToInt32(Console.ReadLine());
            n2 = Convert.ToInt32(Console.ReadLine());
            n3 = Convert.ToInt32(Console.ReadLine());
            n4 = Convert.ToInt32(Console.ReadLine());

            product = n1 * n2 * n3 * n4;

            Console.WriteLine("product of Given No = " + product);


        }
    }
}