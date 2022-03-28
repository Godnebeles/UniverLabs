using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_SimpleCalculator
{
    public class MultiplyCommand : ICommand
    {
        private ICalculator _calculator;
        public double Number { get; set; }
        public double PreviousNumber { get; set; }

        public MultiplyCommand(ICalculator calculator)
        {
            _calculator = calculator;
        }
        public void Execute()
        {
            PreviousNumber = _calculator.CurrentNumber;
            _calculator.Multiply(Number);
        }

        public void Undo()
        {
            //_calculator.Divide(Number);
            _calculator.CurrentNumber = PreviousNumber;
        }
    }
}
