using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceProgramm
{
    class DelegateClass1
    {
        static void Display(string s)
        {
            Console.WriteLine("value of s is:" + s);
 
        }
        public delegate void mydelegate(string a);//delegate creation
        static void Main(string[] args)
        {
            mydelegate obj1 = new mydelegate(Display);// creating instance a delegate(or create object of delegate)
            obj1("Hello");
            Console.Read();
        }
    }
}
