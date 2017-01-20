using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Visual_Studio_Sandbox
{
    class SomeClass
    {
        public int myID = 0;
        public static int myStaticID = 0;
        public SomeClass()
        {
            FakeMain();
        }

        static void FakeMain()
        {
            Console.WriteLine("Hello World (from FakeMain)");
        }

        public static void DoSomething()
        {
            Console.WriteLine("Do Something executed");
            myStaticID = 1000;
        }

        public void DoSomethingInstanced()
        {
            myID = 1000;
            Console.WriteLine("Do Something Instanced executed");
        }
    }
}
