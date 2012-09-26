using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week4Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a, b;
            a = new int[4]{1,2,3,4};
            b = new int[4] {3,4,5,6};
            /*
            Console.WriteLine("Please enter the first number to add:");
            a = Console.ReadLine();
            Console.WriteLine("Please enter the second number to add:");
            b = Console.ReadLine();
            */

            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(Add(a[i], b[i]));
            }

            Console.Read();
        }

        private static int Add( int a,  int b)
        {
            //a = 22;
            return a + b;
        }
      
        private static int Add(string a, string b)
        {
            //a = 22;
            int x, y;
            if (int.TryParse(a, out x) && int.TryParse(b, out y))
            {
                return x + y;
            }
            else
            {
                return -99;
            }
            
        }

    }
}
