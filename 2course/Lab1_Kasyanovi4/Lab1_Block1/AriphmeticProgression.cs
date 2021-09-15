using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Block1
{
    class AriphmeticProgression
    {
        public double step;
        public double startNumber; 

        public AriphmeticProgression(double step, double startNumber/*, int stepCount*/)
        {
            this.step = step;
            this.startNumber = startNumber;
        }
       
        public double this[int i]
        {
            get
            {
                if (i >= 0)
                {
                    return startNumber + i * step;
                }
                else
                {
                    throw new ArgumentException("progression number can't be negative");
                }
            }
        }

        public void PrintAriphmeticProgression(int numElements)
        {
            for (int i = 0; i < numElements; i++)
            {
                Console.Write(this[i] + " ");
            }
            Console.WriteLine();
        }

        public double Sum(int countElemNum)
        {
            return (this[0] + this[countElemNum - 1]) * countElemNum / 2.0;
        }
    }
}
