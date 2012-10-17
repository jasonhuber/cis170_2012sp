using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace deleteme
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int[] Array = { 10, 23, 45, 67, 89 };

            foreach (int val in Array)
                sum *= val;

            Console.WriteLine("Total: {0} ", sum);
            Console.ReadLine();
        }
    }
}
