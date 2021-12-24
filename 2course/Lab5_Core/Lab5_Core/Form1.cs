using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5_Core
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Figure circle = new Circle(50, 200, 100);
            circle.DrawBlack();
            circle.MoveRight();

            Figure rhomb = new Rhomb(200, 200, 100, 200);
            rhomb.DrawBlack();
            rhomb.MoveRight();

            Figure square = new Square(270, 200, 100);
            square.DrawBlack();
            square.MoveRight();

            circle.DrawBlack();
            rhomb.DrawBlack();
            square.DrawBlack();
        }
    }
}
