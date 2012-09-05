using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Huber_Week1
{
    class Week1
    {
        static void Main(string[] args)
        {
            //I type stuff in here... typically..
            /*
            string myname = "Jason";
            int i = 0 ;
            bool istrue = false;

            Console.Write(myname + i.ToString() + istrue.ToString());

            Console.Read();
        
             */
            //this is a single line comment....

            int Age = 0;
            Console.WriteLine("How old are you? \n");
            Age = Convert.ToChar(Console.Read());
            Console.WriteLine("You said you were " + Age.ToString() + " years old!");
            Console.Read();
        }
    }
}
