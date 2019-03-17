using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Constructor
{
    class DerivedClass : BaseClass
    {
        public int  derivednumber;

        //public DerivedClass()
        //{
        //              Console.WriteLine("works Derived default Constructir");
        //}
        public DerivedClass(int number1, int number2) : base(number1)
        {
            Console.WriteLine("works Derived Custom Constructir");
           
            derivednumber = number2;
        }



    }
}
