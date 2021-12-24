using System.Drawing;

namespace Lab5_Core
{
    public class Square : Figure
    {
        public float SideLen { get; set; }

        public Square(float x, float y, float sideLen) : base(x, y)
        {
            SideLen = sideLen;
        }

        public override void DrawBlack()
        {
            graphics.DrawRectangle(Pens.Black, CenterX, CenterY, SideLen, SideLen);
        }
    }
}
