using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceProgramm
{
    class DelegateClass3
    {
        public static void PrintNumber(int num)
        {
            Console.WriteLine("Number is : {0,-12:N0}", num);
        }

        public static void PrintMoney(int money)
        {
            Console.WriteLine("Money is :{0:C}",  money);
        }

        public delegate void print(int value);
        static void Main(string[] args)
        {
            print p1 = PrintNumber;

            p1(100000);
            p1(200);

            p1 = PrintMoney;

            p1(3000);
            p1(30);

            Console.ReadLine();
        }
    }
}
