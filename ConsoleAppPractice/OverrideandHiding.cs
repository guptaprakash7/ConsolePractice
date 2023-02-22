using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPractice
{
    internal class OverrideandHiding
    {
        public static void Main1()
        {

            A a = new B();
            //B b = new B();

            //a.Method1();
            //b.Method1();

            //Console.WriteLine(a.MyProperty);
            //Console.WriteLine(b.MyProperty);

        }
    }

    public class A
    {
        public int MyProperty { get; set; }
        //public A(int myProperty)
        //{
        //    Console.WriteLine("Public A Paramertired");
        //    //MyProperty = myProperty;

        //}
        static A()
        {
            Console.WriteLine("Public A Static");
        }
        public A()
        {
            Console.WriteLine("Public A Default");
            //MyProperty = myProperty;

        }
        public virtual void Method1()
        {
            Console.WriteLine("From Class A");
        }
        //public abstract void Method2();
    }

    public class B : A
    {
        //public B(int myProperty) : base(myProperty)
        //{
        //    Console.WriteLine("Public B Parameterized");
        //}
        static B()
        {
            Console.WriteLine("Public B Static");
        }
        public B()
        {
            Console.WriteLine("Public B Default");
        }

        public override void Method1()
        {
            Console.WriteLine("From Class B ");
            //base.Method1();
        }
    }
}
