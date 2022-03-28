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
        private bool _resultReceived = false;

        private Stack<ICommand> _commandsHistory;

        public CalculatorClient(ICalculator calculator)
        {
            _calculator = calculator;
            _commandsHistory = new Stack<ICommand>();
        }

        public void UndoCommand()
        {
            if (_commandsHistory.Count == 0)
                return;

            ICommand command = _commandsHistory.Pop();

            command.Undo();
        }

        public void Clear()
        {
            _commandsHistory.Clear();
            _calculator.CurrentNumber = 0;
        }

        public void AddOperation(string number, string action)
        {
            if (number == "" && GetCountOperation() > 1)
            {
                if (_resultReceived)
                    _resultReceived = false;
                ChangeOperation(action);       
                return;
            }

            if (_resultReceived && number != "" && GetCountOperation() > 1)
            {
                Clear();
                _resultReceived = false;
            }

            if (number == "")
                return;

            ICommand command;

            if (_commandsHistory.Count == 0)
            {
                //command = new PlusCommand(_calculator);
                //command.Number = Convert.ToDouble(number);
                //command.Execute();
                //_commandsHistory.Push(command);
                _calculator.CurrentNumber = Convert.ToDouble(number);
            }

            if (_commandsHistory.Count >= 1)
            {
                command = _commandsHistory.Peek();
                command.Number = Convert.ToDouble(number);
                command.Execute();
            }         

            command = GetOperation(action);

            _commandsHistory.Push(command);
        }

        private ICommand GetOperation(string action)
        {
            switch (action)
            {
                case "+":
                    return new PlusCommand(_calculator);
                case "-":
                    return new SubstructCommand(_calculator);
                case "x":
                    return new MultiplyCommand(_calculator);
                case "/":
                    return new DivideCommand(_calculator);
            }

            return null;
        }

        public void CalcResult(string number)
        {
            if (_commandsHistory.Count == 0)
                return;

            if (number == "")
            {
                _commandsHistory.Pop();
                return;
            }                

            ICommand command;
            command = _commandsHistory.Peek();
            command.Number = Convert.ToDouble(number);
            command.Execute();

            _resultReceived = true;
        }

        public void ChangeOperation(string action)
        {
            ICommand command = GetOperation(action);
            command.Number = _commandsHistory.Pop().Number;
            _commandsHistory.Push(command);
        }

        public int GetCountOperation()
        {
            return _commandsHistory.Count;
        }

        public double GetCurrentNumber()
        {
            return _calculator.CurrentNumber;
        }
    }
}
