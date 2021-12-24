using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public class Circle : Figure
    {
        public float Radius { get; set; }

        public Circle(float x, float y, float radius) : base(x, y)
        {
            Radius = radius;
        }

        public override void DrawBlack()
        {
            graphics.DrawEllipse(Pens.Black, CenterX, CenterY, Radius, Radius);
        }

        public override void HideDrawingBackGround()
        {
            throw new NotImplementedException();
        }
    }
}
