using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7
{
    public class MyStack <T> : Buffer<T>, IMyStack<T>
    {
        public MyStack(T[] Array) : base(Array)
        {

        }
        public override bool IsEmpty()
        {
            if (top == 0) 
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override bool IsFull()
        {
            if (top == array.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public T Peek()
        {
            return array[top];
        }

        public T Pop()
        {

            Console.WriteLine("Pop from stack:");
            top = top - 1;
            return array[top];


        }

        public void Push(T push)
        {
            array[top + 1] = push;
            top = top + 1;
        }

        public override void Print()
        {
            Console.WriteLine("Your stack looks like this now:");
            Console.Write("[");
            for (int i = 0; i < top + 1; i++)
            {
                Console.Write(" " + array[i] + " ");
            }
            Console.Write("]");
        }

    }
}
