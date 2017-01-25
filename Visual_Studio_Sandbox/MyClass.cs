using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visual_Studio_Sandbox
{
    class MyClass
    {
        public MyClass()
        {
            int a, b, result;

            a = 1;
            b = 0;
            result = 0;

            // This is the main constructor
            Console.WriteLine("Hello World! This comes from MyClass => MyClass() (Constructor)" );
            result = a / b;
        }
    }
}

