using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_SimpleCalculator
{
    public class DivideCommand : ICommand
    {
        private ICalculator _calculator;
        public double Number { get; set; }
        public double PreviousNumber { get; set; }

        public DivideCommand(ICalculator calculator)
        {
            _calculator = calculator;
        }

        public void Execute()
        {
            PreviousNumber = _calculator.CurrentNumber;
            _calculator.Divide(Number);
        }

        public void Undo()
        {
            //_calculator.Multiply(Number);
            _calculator.CurrentNumber = PreviousNumber;
        }
    }
}
