using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HidingPrac
{
    class Program
    {
        class Parent
        {
            public int variable = 273;
            public void Method()
            {
                Console.WriteLine("Parent!");
            }
            public virtual void Method2()
            {
                Console.WriteLine("Parent!");
            }
        }

        class Child : Parent
        {
            public new String variable = "shadwoing";
            public new void Method()
            {
                Console.WriteLine("Child!!");
            }
            public override void Method2()
            {
                Console.WriteLine("Parent!");
            }
        }
        static void Main(string[] args)
        {
            Child child = new Child();
            Parent parent = new Parent();
            Console.WriteLine(child.variable);
            Console.WriteLine(parent.variable);
            child.Method();
            ((Parent)child).Method();
        }
    }
}
