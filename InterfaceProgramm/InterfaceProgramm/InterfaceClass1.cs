using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceProgramm
{
    interface InterfaceClass1
    {
        void GetData();
        void DisplayData();
    }

    class Test : InterfaceClass1
    {
        int Id;
        string name;
        double CA, Bonus;

        public void GetData()
        {
            Console.WriteLine("Enter Data:");
            this.Id = Convert.ToInt32(Console.ReadLine());
            this.name = Console.ReadLine();
            this.CA = Convert.ToDouble(Console.ReadLine());
            this.Bonus = Convert.ToDouble(Console.ReadLine());

        }

        public void DisplayData()
        {
            Console.WriteLine("Details are:");
            Console.WriteLine("Id is:" + this.Id);
            Console.WriteLine("Name is:" + this.name);
            Console.WriteLine("CA is :" + this.CA);
            Console.WriteLine("Bonus Are:" + this.Bonus);
        }
        static void Main(string[] args)
        {
            Test t1 = new Test();
            t1.GetData();
            t1.DisplayData();

            Console.ReadLine();
        }
    }
}
