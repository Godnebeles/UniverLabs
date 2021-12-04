using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_block1
{
    class AreaEquation
    {
        private double[] arrEquation = new double[4];

        //Ax + By + Cz + D = 0
        //arr[0] - A, arr[1] - B, arr[2] - C, arr[3] - D
        public AreaEquation(double A, double B, double C, double D)
        {
            if (A != 0 && B != 0 && C != 0)
            {
                arrEquation[0] = A;
                arrEquation[1] = B;
                arrEquation[2] = C;
                arrEquation[3] = D;
            }
            else throw new Exception("A, B, C - сan't be zero");
        }

        // find decussation
        public double DecussationPoint(string letter)
        { 
            if(letter == "x") return -arrEquation[0] / arrEquation[3];
            if(letter == "y") return -arrEquation[1] / arrEquation[3];
            if (letter == "z") return -arrEquation[2] / arrEquation[3];
            else throw new Exception("This axis is missing");
        }

        public string PrintDecussationPoint(string letter)
        {
            if (letter == "x") return DecussationPoint(letter) + "; 0; 0;" ;
            else if (letter == "y") return "0; " + DecussationPoint(letter) + "; 0;";
            else if (letter == "z") return "0; 0; " + DecussationPoint(letter) + ";";
            else throw new Exception("This axis is missing");
        }

        // input output
        public void Input()
        {
            Console.Write("A = ");
            arrEquation[0] = int.Parse(Console.ReadLine());
            Console.Write("B = ");
            arrEquation[1] = int.Parse(Console.ReadLine());
            Console.Write("C = ");
            arrEquation[2] = int.Parse(Console.ReadLine());
            Console.Write("D = ");
            arrEquation[3] = int.Parse(Console.ReadLine());
        }
        public void Output()
        {      
            Console.WriteLine($"\nAx={arrEquation[0]}, By={arrEquation[1]}, Cz={arrEquation[0]}, D={arrEquation[3]}");
        }

        // indexer
        public double this[int i]
        {
            get
            {
                return arrEquation[i];
            }
            set
            {
                arrEquation[i] = value;
            }
        }

        // get-sets
        public double A
        {
            get { return arrEquation[0]; }
            set { arrEquation[0] = value; }
        }
        public double B
        {
            get { return arrEquation[1]; }
            set { arrEquation[1] = value; }
        }
        public double C
        {
            get { return arrEquation[2]; }
            set { arrEquation[2] = value; }
        }
        public double D
        {
            get { return arrEquation[3]; }
            set { arrEquation[3] = value; }
        }
    }
}
