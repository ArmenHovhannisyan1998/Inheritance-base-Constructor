using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass instance = new DerivedClass(100,200);
            Console.WriteLine(instance.basenumber);
            Console.WriteLine(instance.derivednumber);


            Console.ReadKey();
        }
    }
}
