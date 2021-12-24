using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
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
            throw new NotImplementedException();
        }

        public override void HideDrawingBackGround()
        {
            throw new NotImplementedException();
        }
    }
}
