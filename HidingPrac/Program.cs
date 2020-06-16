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
            Child c = new Child();
            Console.WriteLine("하이딩");
            Console.WriteLine("Child variable : "+c.variable);
            Console.WriteLine("Parent variable : " + ((Parent)c).variable);
            c.Method();
            ((Parent)c).Method();
            Console.WriteLine("오버라이딩");
            c.Method2();
            ((Parent)c).Method2();
        }
    }
}
