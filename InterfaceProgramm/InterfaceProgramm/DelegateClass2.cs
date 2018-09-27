using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceProgramm
{
    class DelegateClass2
    {
        public void Display(string s) // here i m creating function 
        {
            Console.WriteLine("Value of S is:" + s);
        }
    }
    public delegate void mydelegate(string s); // here i m defining delegate
    class TestDelegate
    {
        static void Main(string[] args)
        {
            DelegateClass2 obj1 = new DelegateClass2();// first create the object of function bcz we r using outside of class thats why
            mydelegate obj2 = new mydelegate(obj1.Display);// then creating object of delegate
            obj2("Hello Bizruntime");// providing value
            Console.Read();
        }
    }
}
