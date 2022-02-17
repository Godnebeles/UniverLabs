using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_SimpleCalculator
{
    public class CalculatorClient
    {
        private ICalculator _calculator;

        private Stack<ICommand> _commandsHistory;

        public CalculatorClient(ICalculator calculator)
        {
            _calculator = calculator;
            _commandsHistory = new Stack<ICommand>();
        }

        public void UndoCommand()
        {
            ICommand command = _commandsHistory.Pop();

            command.Undo();
        }

        public void Clear()
        {
            _commandsHistory.Clear();
            _calculator.Number = 0;
        }

        public void AddOperation(double number, string action)
        {
            ICommand command;

            if (_commandsHistory.Count == 0)
            {
                command = new PlusCommand(_calculator);
                command.Number = number;
                command.Execute();
                _commandsHistory.Push(command);
            }
            if (_commandsHistory.Count > 1)
            {
                command = _commandsHistory.Peek();
                command.Number = number;
                command.Execute();
            }

            switch (action)
            {
                case "+":
                    command = new PlusCommand(_calculator);
                    break;
                case "-":
                    command = new SubstructCommand(_calculator);
                    break;
                case "x":
                    command = new MultiplyCommand(_calculator);
                    break;
                case "/":
                    command = new DivideCommand(_calculator);
                    break;
                default:
                    return;
            }

            _commandsHistory.Push(command);
        }

        public void CalcResult(double number)
        {
            if (_commandsHistory.Count == 0)
                return;

            ICommand command;
            command = _commandsHistory.Peek();
            command.Number = number;
            command.Execute();
        }

        public double GetCurrentNumber()
        {
            return _calculator.Number;
        }

    }
}
