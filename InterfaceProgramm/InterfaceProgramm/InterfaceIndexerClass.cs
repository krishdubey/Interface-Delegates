using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceProgramm
{
    public interface InterfaceIndexerClass
    {
        int this[int index]
        {
            get;
            set;
        }

    }

    class IndexerClass : InterfaceIndexerClass
    {
        private int[] arr = new int[10];
        public int this[int index]   // indexer declaration
        {
            get
            {
                
                return arr[index];
            }
            set
            {
                arr[index] = value;
            }
        }
    }

    class MainClass
    {
        static void Main()
        {
            IndexerClass test = new IndexerClass();
            Random rd = new Random();
            // Call the indexer to initialize its elements.
            for (int i = 0; i < 10; i++)
            {
                test[i] = rd.Next(0,9);
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Element #{0} = {1}", i, test[i]);
            }

            
            System.Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();
        }
    }
}