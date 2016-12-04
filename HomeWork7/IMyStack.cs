using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7
{
    public interface IMyStack <T> : IBuffer<T>
    {

        T Pop();

        T Peek();

        void Push(T push);
    }
}
