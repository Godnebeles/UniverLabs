using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_SimpleCalculator
{
    public class Calculator : ICalculator
    {
        public double Number { get; set; }

        public Calculator()
        {
            Number = 0;
        }

        public void Divide(double number)
        {
            Number /= number;
        }

        public void Substruct(double number)
        {
            Number -= number;
        }

        public void Multiply(double number)
        {
            Number *= number;
        }

        public void Plus(double number)
        {
           Number += number;
        }
    }
}
