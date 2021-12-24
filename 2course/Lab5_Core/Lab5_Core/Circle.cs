using System.Drawing;

namespace Lab5_Core
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
    }
}
