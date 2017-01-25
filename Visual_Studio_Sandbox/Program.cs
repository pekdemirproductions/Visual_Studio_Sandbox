﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visual_Studio_Sandbox
{
    public class Program
    {
        public static int Main(String[] args)
        {
            // START OF PROGRAM (Say "Hello" and print start time)
            StartOfProgram ();

            #region Active Method Calls
                try
                {
                    MyClass myClassInstance = new MyClass();
                }
                catch (Exception e)
                {
                    Console.WriteLine("I have caught an exception.");
                    Console.WriteLine(e);
                }
            #endregion Active Method Calls

            #region Unused Method Calls

                // ACCESS EXTERNAL CLASSES (Do some random shit)
                // AccessExternalClasses();

                // Test Exception Handling
                // MyErrorHandler.ErrorHandler(0);

            #endregion Unused Method Calls

            // END OF PROGRAM (Say "Goodbye" & wait for "Enter")
            EndOfProgram();

        }

        #region Unused Methods
            static void AccessExternalClasses()
            {
                SomeClass program1 = new SomeClass();

                SomeClass.myStaticID = 3000;
                program1.myID = 3000;

                Console.WriteLine("SomeClass.myStaticID = {0}", SomeClass.myStaticID);
                Console.WriteLine("SomeClass.myID = {0}", program1.myID);

                SomeClass.DoSomething();
                program1.DoSomethingInstanced();

                Console.WriteLine("SomeClass.myStaticID = {0}", SomeClass.myStaticID);
                Console.WriteLine("SomeClass.myID = {0}", program1.myID);
            }
        #endregion Unused Methods

        static void StartOfProgram()
        {
            Console.WriteLine("Hello World!");
            DateTime startOfProgram = DateTime.Now;
            Console.WriteLine("Program started at: {0}", startOfProgram);
        }

        static void EndOfProgram ()
        {
            Console.WriteLine("End of Program. Goodbye!");
            Console.ReadLine();
        }
    }
}
