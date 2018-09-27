using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceProgramm
{
   public class Class2
    {
        internal static int x = 55;
        public static int y = 22;

    }

    public class DerivedC : Class2
    {
        // Hide field 'x'.
       new public static int x = 100;

        static void Main()
        {
           // DerivedC c1 = new DerivedC();
            // Display the new value of x:
            Console.WriteLine(x);

            // Display the hidden value of x:
            Console.WriteLine(x);

            // Display the unhidden member y:
            Console.WriteLine(y);
            Console.ReadLine();
        }

    }
}
