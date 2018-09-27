using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceProgramm
{
    class MultiDelegate1
    {
        public void Add(int a, int b)
        {
            Console.WriteLine("Value Of Add is:" + (a+b));
        }
        public void Sub(int a, int b)
        {
            Console.WriteLine("Value of Sub is:" + (a - b));
        }
        public void Mul(int a, int b)
        {
            Console.WriteLine("Value of Mul is:" + (a * b));
        }
        public void Div(int a, int b)
        {
            Console.WriteLine("Value Of Div is:" + (a / b));
        }
    }
    public delegate void multidelegate(int a, int b);

    class TestMulDelegate
    {
        static void Main(string[] args)
        {
            MultiDelegate1 m1 = new MultiDelegate1();
            multidelegate mu = new multidelegate(m1.Add);

            mu += m1.Sub;
            mu += m1.Mul;
            mu += m1.Div;

            mu(20, 10);

            Console.WriteLine();
            mu -= m1.Mul;
            mu -= m1.Div;

            mu(30, 10);
            Console.ReadLine();
        }
    }
}
