using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visual_Studio_Sandbox
{
    public static class MyErrorHandler
    {
        public static void ErrorHandler(int passedArgument)
        {
            Console.WriteLine("This comes from the ErrorHandler method inside the 'MyErrorHandler' class");
            Console.WriteLine("Received argument: {0}", passedArgument);



            Console.WriteLine("Enter a number to divide by: ");
            int a;
            bool check = int.TryParse(Console.ReadLine(), out a);

            if (check == true)
            {
                Console.WriteLine("Input was: {0}", a);
            }
            else 
            {
                Console.WriteLine("That was no number!");
            }

            try
            {
                if (passedArgument == 0)
                {
                    throw new ArgumentException("This is so terrible!");
                }
                int calculation;
                calculation = a / passedArgument;
                Console.WriteLine("Result of calculation was: {0}", calculation);

            }
            catch (Exception Hanswurst)
            {
                Console.WriteLine("Something terrible has happened!");
                Console.WriteLine(Hanswurst);

            }
            finally
            {
                Console.WriteLine("This comes from the 'finally'-Block.");
            }

        }
    }
}
