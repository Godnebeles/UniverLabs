using System.Drawing;

namespace Lab5_Core
{
    public class Rhomb : Figure
    {
        public float HorDiagLen { get; set; }
        public float VertDiagLen { get; set; }

        public Rhomb(float x, float y, float horDiagLen, float vertDiagLen) : base(x,y)
        {
            HorDiagLen = horDiagLen;
            VertDiagLen = vertDiagLen;
        }

        public override void DrawBlack()
        {
            graphics.DrawPolygon(Pens.Black, GetPolygons());
        }

        private PointF[] GetPolygons()
        {
            PointF[] points = new PointF[4];

            points[0] = new PointF((CenterX - HorDiagLen/2), (CenterY));
            points[2] = new PointF((CenterX + HorDiagLen/2), (CenterY));
            points[1] = new PointF((CenterX), (CenterY + VertDiagLen/2));
            points[3] = new PointF((CenterX), (CenterY - VertDiagLen/2));

            return points;
        }
    }
}
