using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleAppPractice
{
    internal class AsyncAwaitSample
    {
        static void Main2(string[] args)
        {

            Console.WriteLine("Main Started");
            MyMethod();
            Console.WriteLine("Main End");
            Console.ReadKey();
        }

        public async static void MyMethod()
        {
            Console.WriteLine("My Method Started");

            //Thread.Sleep(TimeSpan.FromSeconds(10));

            await Task.Delay(TimeSpan.FromSeconds(10));

            Console.WriteLine("My Method End");
        }
    }
}