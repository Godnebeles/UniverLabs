using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Calculator
{
    public interface ICommand
    {
        public abstract void Execute();
        public abstract void Undo();
    }
}
