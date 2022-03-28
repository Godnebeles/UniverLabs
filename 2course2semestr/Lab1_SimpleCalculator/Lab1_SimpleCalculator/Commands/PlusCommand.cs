using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_SimpleCalculator
{
    public class PlusCommand : ICommand
    {
        private ICalculator _calculator;
        public double Number { get; set; }
        public double PreviousNumber { get; set; }

        public PlusCommand(ICalculator calculator)
        {
            _calculator = calculator;
        }

        public void Execute()
        {
            PreviousNumber = _calculator.CurrentNumber;
            _calculator.Plus(Number);
        }

        public void Undo()
        {
            //_calculator.Substruct(Number);
            _calculator.CurrentNumber = PreviousNumber;
        }
    }
}
