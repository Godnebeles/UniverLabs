using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_SimpleCalculator
{
    public interface ICommand
    {
        double Number { get; set; }
        void Execute();
        void Undo();
    }
}
