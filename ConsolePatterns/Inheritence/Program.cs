using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence
{
    class A
    {
        public A(string name)
        {
            _name = name;
        }

        private string _name;

        public virtual void PrintName()
        {
            Console.WriteLine(_name);
        }
    }

    class B : A
    {
        public B(string name, string subject) : base(name)
        {
            _subject = subject;
        }

        private string _subject;

        public override void PrintName()
        {
            Console.Write("InstanceOf B Class: ");
            base.PrintName();
        }

        public virtual void PrintSubject()
        {
            Console.WriteLine(_subject);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            A a = new A("Shiv");

            B b = new B("Shiv", "CS");

            a.PrintName();//Shiv
            
            b.PrintName();//Shiv
            b.PrintSubject();//CS
        }
    }
}
