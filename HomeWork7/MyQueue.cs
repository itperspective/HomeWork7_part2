using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7
{
    public class MyQueue <T> : Buffer<T>
    {
        public MyQueue(T[] Array) : base(Array)
        {

        }

        public override bool IsEmpty()
        {
            if (count == 0)
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
            if (head == tail & count != 0)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        public void Enqueue(T enqueue)
        {
            array[head] = enqueue;
            if (head < array.Length - 1)
            {
                head = head + 1;
            }

            else
            {
                head = 0;
            }

            count = count + 1;
        }

        public void Dequeue()
        {
            Console.WriteLine("Poped: " + array[tail]);

            if (tail < array.Length - 1)
            {
                tail = tail + 1;
            }

            else
            {
                tail = 0;
            }

            count = count - 1;


        }

        public override void Print()
        {

            Console.WriteLine("Your queue looks like this now:");
            Console.Write("[");


            if (head > tail)
            {
                for (int i = tail; i < head; i++)
                {

                    Console.Write(" " + array[i] + " ");
                }
            }

            if (head <= tail & count != 0)
            {
                for (int i = tail; i < array.Length; i++)
                {
                    Console.Write(" " + array[i] + " ");
                }

                for (int i = 0; i < head; i++)
                {
                    Console.Write(" " + array[i] + " ");
                }


            }
            if (head <= tail & count == 0)
            {

            }



            Console.Write("]");
        }
    }
}
