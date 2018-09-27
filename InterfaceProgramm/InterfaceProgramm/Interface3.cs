using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceProgramm
{
    interface Interface3
    {
        void F2();
    }
    interface Interface4
    {
        void F2();

    }

    class D : Interface3, Interface4
    {
        void Interface3.F2()
        {
            Console.WriteLine("Welcome");
        }
        void Interface4.F2()
        {
            Console.WriteLine("Hello");
        }
    }
    class ClsMultiple1
    {
        static void Main(string[] args)
        {
            D obj1 = new D();
            Interface3 obj2 = (Interface3)obj1; // this is explicit interface implementation
            Interface4 obj3 = (Interface4)obj1;
            obj2.F2();
            obj3.F2();
            Console.ReadLine();
        }
    }
}
