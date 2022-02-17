using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_SimpleCalculator
{
    public interface ICalculator
    {
        double Number { get; set; }
        void Plus(double number);
        void Divide(double number);
        void Multiply(double number);
        void Substruct(double number);
    }
}
