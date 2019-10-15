using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // test method inheritance
            // normally wouldn't use cc or gcc as a class name
            ChildClass cc = new ChildClass();
            GrandChileClass gcc = new GrandChileClass();

            Console.WriteLine("Calling method from gcc");
            gcc.BaseMethod();
            gcc.ChildMethod();
            gcc.GrandChildMethod();
            Console.WriteLine();

            Console.WriteLine("Calling method from cc");
            cc.BaseMethod();
            cc.ChildMethod();
            // cc.GrandChildMethod();
            Console.WriteLine();

            // test base class fields
            BaseClass bc = new BaseClass(123, 456);
            bc.PrintState();
            Console.WriteLine();

            // test child print state
            ChildClass cc2 = new ChildClass(987, 654, 345);
            cc2.PrintState();
        }
    }
}
