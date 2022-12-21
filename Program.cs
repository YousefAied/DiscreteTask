using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project___Discrete_Structure_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  Yousef Aied alshaer
            //  Mohamed Rizk

            int x, y, r, factor = 0;
            Console.WriteLine("Please enter the first prime numbers");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the last  prime numbers");
            y = int.Parse(Console.ReadLine());

            Console.WriteLine("the prime numbers");

            for (int i = x; i > 0 & i <= y; i++)
            {
                for (int z = 1; z <= y; z++)
                {
                    r = i % z;
                    if (r == 0)
                        factor += 1;
                }

                if (factor == 2)
                {
                    Console.WriteLine(i);
                }
                factor = 0;

            }
            Console.ReadKey();



            //  Yousef Aied alshaer
            //  Mohamed Rizk

            //int n, i, sum;
            //int mn, mx;

            //Console.WriteLine(" Please enter the first Perfect numbers : ");
            //mn = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(" Please enter the lest Perfect numbers:  ");
            //mx = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("The Perfect numbers : ");
            //for (n = mn; n <= mx; n++)
            //{
            //    i = 1;
            //    sum = 0;
            //    while (i < n)
            //    {
            //        if (n % i == 0)
            //            sum = sum + i;
            //        i++;
            //    }
            //    if (sum == n)
            //        Console.Write("{0} ", n);
            //}
            //Console.Write("\n");

            //Console.ReadKey();


















        }
    }
}
