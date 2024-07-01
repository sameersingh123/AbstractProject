using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractProject
{
    abstract class AbsParent     //instance of an abstarct class cannot be created
    {
        public void Add(int a, int b)         //non-abstract method
        {
            Console.WriteLine(a + b);
        }
        public void Sub(int a, int b)
        {
            Console.WriteLine(a - b);
        }
        public abstract void Multiply(int a, int b); //abstract method(Mandatory overriding)
        public abstract void Div(int a, int b); //abstract method(Mandatory overriding)


    }
}
