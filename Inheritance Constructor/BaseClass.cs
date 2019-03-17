using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Constructor
{
    class BaseClass
    {
        public int basenumber;
        // default ConstructorC:
        //{
        //    Console.WriteLine("works Base default Constructir");
        //}
        //Custom Constructor
      public  BaseClass(int basenumber) 
        {
            Console.WriteLine("works Base custom Constructir");
            this.basenumber = basenumber;
        }
    }
}
