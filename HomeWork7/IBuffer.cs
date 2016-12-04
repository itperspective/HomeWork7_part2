using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7
{
    public interface IBuffer<T> : IPrintable
    {
        void Print();

        bool IsEmpty();

        bool IsFull();

   

    }
}
