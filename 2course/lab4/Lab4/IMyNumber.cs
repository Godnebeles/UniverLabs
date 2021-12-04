using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    interface IMyNumber<T> where T : IMyNumber<T>
    {
        T Add(T b);
        T Substract(T b);
        T Multiply(T b);
        T Divide(T b);

    }
}
