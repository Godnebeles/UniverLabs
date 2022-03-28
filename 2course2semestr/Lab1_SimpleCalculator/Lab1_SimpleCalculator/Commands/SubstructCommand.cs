using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_SimpleCalculator
{
    public class SubstructCommand : ICommand
    {
        private ICalculator _calculator;
        public double Number { get; set; }
        public double PreviousNumber { get; set; }

        public SubstructCommand(ICalculator calculator)
        {
            _calculator = calculator;
        }

        public void Execute()
        {
            PreviousNumber = _calculator.CurrentNumber;
            _calculator.Substruct(Number);
        }

        public void Undo()
        {
            //_calculator.Plus(Number);
            _calculator.CurrentNumber = PreviousNumber;
        }
    }
}
