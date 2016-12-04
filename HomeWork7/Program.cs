using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7
{
    class Program
    {
        static void Main(string[] args)
        {
            int size;
            Console.WriteLine("Please Enter Array size:");
            while(!Int32.TryParse(Console.ReadLine(), out size))
            {
                Console.WriteLine("Please Enter int!");
            }

            int[] array = new int[size];
            Console.WriteLine("Please Enter array values:");
            for (int i=0; i<array.Length; i++)
            {
                while(!Int32.TryParse(Console.ReadLine(), out array[i]))
                {
                    Console.WriteLine("Please Enter int!!!");
                }
            }

            IBuffer<int> ibuffer = new MyStack<int>(array);
            MyStack<int> mystack = new MyStack<int>(array);
            IMyStack<int> imystack = new MyStack<int>(array);

       

            Console.ReadLine();

        }
    }
}
