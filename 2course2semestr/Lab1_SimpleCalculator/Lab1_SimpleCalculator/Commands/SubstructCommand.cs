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

        public SubstructCommand(ICalculator calculator)
        {
            _calculator = calculator;
        }

        public void Execute()
        {
            _calculator.Substruct(Number);
        }

        public void Undo()
        {
            _calculator.Plus(Number);
        }
    }
}
