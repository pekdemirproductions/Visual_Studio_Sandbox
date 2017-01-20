using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visual_Studio_Sandbox

{
    public class Spaceship
    {
        public Spaceship(string[] args)
        {
            MySpaceship Nostromo = new MySpaceship();
            Console.WriteLine("Nostromo capacity: " + Nostromo.freightCapacity);

            Dropship Betty = new Dropship();
            Console.WriteLine("Betty capacity: " + Betty.freightCapacity);
            Console.WriteLine("Betty Ship ID: " + Betty.shipID);
            Console.WriteLine("Ship Speed: " + SpaceCalc.ShipSpeed(5, 3));

            SomeClass x = new SomeClass();
            Console.WriteLine("X myID: " + x.myID);

            Console.ReadLine();

        }

        public class MySpaceship
        {
            public static int totalShips = 0;
            public int shipID = -1;
            public string shipName = "Default";
            public int freightCapacity = 1000;
            public MySpaceship()
            {
                totalShips++;
            }

        }

        public class Dropship : MySpaceship
        {
            public new int freightCapacity = 200;
        }

        public static class SpaceCalc
        {
            public static int ShipSpeed(int x, int y)
            {
                return x * y;
            }
        }

    }
}
