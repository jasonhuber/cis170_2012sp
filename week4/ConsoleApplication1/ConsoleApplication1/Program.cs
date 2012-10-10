using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4LabPhoneDialing
{
    class Program
    {


        void Main(ref char[] args)
        {
            // declare variables and intitialize values
            char var1, var2, var3, var4, var5, var6, var7;

            //collectionOfVariables += var1+var2+var3+var4+var5+var6+var7;

            // Call GetInput() method
            GetInput(ref  var1, ref  var2, ref  var3,
               ref  var4, ref  var5, ref  var6, ref  var7);



            // Call ProcessInput() method
            ProcessInput(ref  var1, ref  var2, ref  var3,
                ref  var4, ref  var5, ref  var6, ref  var7);


            // Call ToDigit() method
            ToDigit(character);





            // Call ShowResults() method

            ShowResults(ref  var1, ref  var2, ref  var3,
               ref  var4, ref  var5, ref  var6, ref  var7);


        }

        public void GetInput(ref char var1, ref char var2, ref char var3,
            ref char var4, ref char var5, ref char var6, ref char var7)
        {
            // Get user input

            Console.WriteLine(" Enter 7 characters from keyboard using letters, no symbols ");
            string input = Console.ReadLine();
            if (input.Length > 0)
                var1 = input[0];
            if (input.Length > 1)
                var2 = input[1];
            if (input.Length > 2)
                var3 = input[2];
            if (input.Length > 3)
                var4 = input[3];
            if (input.Length > 4)
                var5 = input[4];
            if (input.Length > 5)
                var6 = input[5];
            if (input.Length > 6)
                var7 = input[6];

            return;

            //while (Console.ReadLine = (0 || 1 || 2 || 3 || 4 || 5 || 6 || 7 || 8 || 9))
            //{
            //  Console.WriteLine(" Invalid character, please try again ");
            //}


            /*  Console.WriteLine(" Enter 7 characters from keyboard using letters, no symbols ");
              var1 = char.Parse(Console.ReadLine());
              Console.WriteLine(" Enter 7 characters from keyboard using letters, no symbols ");
              var2 = Console.ReadLine();
              Console.WriteLine(" Enter 7 characters from keyboard using letters, no symbols ");
              var3 = Console.ReadLine();
              Console.WriteLine(" Enter 7 characters from keyboard using letters, no symbols ");
              var4 = Console.ReadLine();
              Console.WriteLine(" Enter 7 characters from keyboard using letters, no symbols ");
              var5 = Console.ReadLine();
              Console.WriteLine(" Enter 7 characters from keyboard using letters, no symbols ");
              var6 = Console.ReadLine();
              Console.WriteLine(" Enter 7 characters from keyboard using letters, no symbols ");
              var7 = Console.ReadLine();
              Console.WriteLine(" Enter 7 characters from keyboard using letters, no symbols ");
                
              collectionOfVariables = Convert.ToChar (var1+var2+var3+var4+var5+var6+var7);
         
              return collectionOfVariables; */
        }

        public int ToDigit(ref char character)
        {
            character = char.ToUpper(character);
            switch (character)
            {

                case 'W':
                case 'X':
                case 'Y':
                case 'Z':
                case '9':
                    character = '9';
                    break;
                case 'T':
                case 'U':
                case 'V':
                case '8':
                    character = '8';
                    break;
                case 'P':
                case 'Q':
                case 'R':
                case 'S':
                case '7':
                    character = '7';
                    break;
                case 'M':
                case 'N':
                case 'O':
                case '6':
                    character = '6';
                    break;
                case 'J':
                case 'K':
                case 'L':
                case '5':
                    character = '5';
                    break;
                case 'G':
                case 'H':
                case 'I':
                case '4':
                    character = '4';
                    break;
                case 'D':
                case 'E':
                case 'F':
                case '3':
                    character = '3';
                    break;
                case 'A':
                case 'B':
                case 'C':
                case '2':
                    character = '2';
                    break;

                default:
                    // Weird character, return error code -1
                    return -1;
                    break;

                    // Good characters, return all go code 0

                    return 0;

            }

        }


        public int ProcessInput(ref char var1, ref char var2, ref char var3,
             ref char var4, ref char var5, ref char var6, ref char var7)
        {
            if (ToDigit(ref var1) == -1)
                return -1;
            if (ToDigit(ref var2) == -1)
                return -1;
            if (ToDigit(ref var3) == -1)
                return -1;
            if (ToDigit(ref var3) == -1)
                return -1;
            if (ToDigit(ref var4) == -1)
                return -1;
            if (ToDigit(ref var5) == -1)
                return -1;
            if (ToDigit(ref var6) == -1)
                return -1;
            if (ToDigit(ref var7) == -1)
                return -1;
            else



                // No problem here
                return 0;



        }

        // show results

        public static string ShowResults(ref char var1, ref char var2, ref char var3,
        ref char var4, ref char var5, ref char var6, ref char var7)
        {

            Console.WriteLine(" the characters you entered = phone number.......{0}{1}{2}{3}{4}{5}{6}", var1, var2, var3,
                                                                                                var4, var5, var6, var7);
            Console.ReadLine();

        }

    }
}




