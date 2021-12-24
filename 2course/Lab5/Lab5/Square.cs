using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
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

        }

        public override void HideDrawingBackGround()
        {
            throw new NotImplementedException();
        }
    }
}
