using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    internal class Exercise1
    {
        public static int Divide(int a, int b)
        {
            return a / b;
        }
        public static void DivideUserInputs()
        {
            while (true)
            {

                try
                {
                    int[] numbers = GetUserInputs();
                    int result = Divide(numbers[0], numbers[1]);
                    Console.WriteLine(result);
                    break;
                }
                catch(FormatException ex)
                {
                    Console.WriteLine("not a number");
                    //DivideUserInputs();
                }

           

            }
        }
        private static int[] GetUserInputs()
        {
            Console.WriteLine("Enter divisor");
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter dividend");
            int input2 = int.Parse(Console.ReadLine());
            return new int[] { input, input2 };

        }
    }
}
