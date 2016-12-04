using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7
{
    public interface IMyQueue <T> : IBuffer<T>
    {

        void Dequeue();

        void Enqueue(T enqueue);
    }
}
