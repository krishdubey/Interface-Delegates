using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceProgramm
{
    interface Interface1
    {
        void F1();
    }
    interface Interface2
    {
        void F1();

    }

    class C : Interface1,Interface2
    {
        public void F1()
        {
            Console.WriteLine("Welcome");
        }

    }
    class ClsMultiple
    {
        static void Main(string[] args)
        {
            C obj1 = new C();
            obj1.F1();
            Console.ReadLine();
        }
    }
}
