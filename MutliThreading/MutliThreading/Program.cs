using System;
using System.Threading;

namespace MutliThreading
{
    class Program
    {
        static void Main(string[] args)
        {
            Program prog = new Program();

            Thread addition = new Thread(prog.Add);
            Thread substraction = new Thread(prog.Sub);

            addition.Start();
            substraction.Start();

            addition.Join();
            substraction.Join();
        }


        public void Add()
        {
            int result = 5 + 6;
            Console.WriteLine("Add: " + result);

        }

        public void Sub()
        {
            int result = 6 - 5;
            Console.WriteLine("Sub: " + result);

        }
    }
}
