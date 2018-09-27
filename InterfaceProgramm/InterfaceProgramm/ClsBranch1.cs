using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceProgramm
{
    class ClsBranch1
    {
        int Bcode;
        string BName;
        string BAddress;

        public void GetBData()
        {
            Console.WriteLine("Enter Branch Details:");
            this.Bcode = Convert.ToInt32(Console.ReadLine());
            this.BName = Console.ReadLine();
            this.BAddress = Console.ReadLine();
        }

        public void DisplayBData()
        {
            Console.WriteLine("Branch Details are:");
            Console.WriteLine("Branch code is:" + this.Bcode);
            Console.WriteLine("Branch Name Is:" + this.BName);
            Console.WriteLine("Branch Address is:" + this.BAddress);
        }
    }

    interface clsEmployee9
    {
        void GetEmpData();
        void DisplayEmpData();
    }
    
    //class clsManager2 : clsEmployee9 , ClsBranch1
    class clsManager2 : ClsBranch1, clsEmployee9
    {
        int EmpId;
        string EName;
        double CA, Bonus;

        public void GetEmpData()
        {
            Console.WriteLine("Enter Manager Details:");
            this.EmpId = Convert.ToInt32(Console.ReadLine());
            this.EName = Console.ReadLine();
            this.CA = Convert.ToDouble(Console.ReadLine());
            this.Bonus = Convert.ToDouble(Console.ReadLine());
        }
        public void DisplayEmpData()
        {
            Console.WriteLine("Manager Details are:");
            Console.WriteLine("Manager Id is:" + this.EmpId);
            Console.WriteLine("Manager Name is:" + this.EName);
            Console.WriteLine("CA is:" + this.CA);
            Console.WriteLine("Bonus is:" + this.Bonus);
        }
    }

    class ClsMultipleInheritance
    {
        static void Main(string[] args)
        {
            clsManager2 obj1 = new clsManager2();
            obj1.GetBData();
            obj1.GetEmpData();
            obj1.DisplayBData();
            obj1.DisplayEmpData();

            Console.ReadLine();
        }
    }
}
