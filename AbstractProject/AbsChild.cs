using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AbstractProject
{
     class AbsChild : AbsParent
    {
        public override void Multiply(int a, int b)  //Mandatory overriding
        {
            Console.WriteLine(a * b);
        }
        public override void Div(int a, int b)      //Mandatory overriding
        {
            Console.WriteLine(a / b);
        }
        static void Main()
        {
            AbsChild c=new AbsChild();
            c.Add(10, 20);
            c.Sub(20, 10);
            c.Multiply(10, 20);
            c.Div(20, 10);

            //we can create a reference of parent class using a child class instance
            //Parent class references can always call class child class overriddien members as they are not purely child class members but cannot call pure child class members

            AbsParent p = c;
            p.Add(10, 20);
            p.Sub(20, 10);
            p.Multiply(10, 20);
            p.Div(20, 10);

        }
    }
}
