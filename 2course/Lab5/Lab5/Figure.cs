using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public abstract class Figure
    {
        public Graphics graphics = Form1.ActiveForm.CreateGraphics();
        public float CenterX { get; set; }
        public float CenterY { get; set; }

        public Figure(float x, float y)
        {
            CenterX = x;
            CenterY = y;
        }

        public abstract void DrawBlack();
        public abstract void HideDrawingBackGround();

        public void MoveRight()
        {
            for (float i = CenterX; CenterX < CenterX + 20; i += 0.5f)
            {
                HideDrawingBackGround();
                DrawBlack();
                System.Threading.Thread.Sleep(100);
            }
        }
    }
}
