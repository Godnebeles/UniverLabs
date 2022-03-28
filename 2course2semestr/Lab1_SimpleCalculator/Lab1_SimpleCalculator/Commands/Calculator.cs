using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_SimpleCalculator
{
    public class Calculator : ICalculator
    {
        public double CurrentNumber { get; set; }

        public Calculator()
        {
            CurrentNumber = 0;
        }

        public void Divide(double number)
        {
            CurrentNumber /= number;
        }

        public void Substruct(double number)
        {
            CurrentNumber -= number;
        }

        public void Multiply(double number)
        {
            CurrentNumber *= number;
        }

        public void Plus(double number)
        {
           CurrentNumber += number;
        }
    }
}
