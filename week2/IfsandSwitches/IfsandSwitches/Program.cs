using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IfsandSwitches
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your grade.");
            int grade = 0;
            string Letter = "";
            if (int.TryParse(Console.ReadLine(), out grade))
            {
                //Console.Write(grade);
                if (grade >= 90)
                {
                    Letter = "A";
                }
                else if (grade >= 80)
                {
                    Letter = "B";
                }
                else if (grade >= 70)
                {
                    Letter = "C";
                }
                else if (grade >= 60)
                {
                    Letter = "D";
                }
                else { Letter = "F"; }
                Console.Write("1. You earned a(n) {0} with a grade of {1}", Letter, grade);

                switch (Letter)
                {
                    case "A":
                        grade = 100;
                        break;
                    case "B":
                        grade = 89;
                        break;
                    case "C":
                        grade = 79;
                        break;
                    case "D":
                        grade = 69;
                        break;
                    default:
                        grade = 59;
                        break;
                }
                
            }
            else
            {
                Console.Write("You did not enter a valid grade.");
            }
            Console.Read();

        }
    }
}
