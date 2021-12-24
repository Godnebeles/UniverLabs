using System.Drawing;

namespace Lab5_Core
{
    public abstract class Figure
    {
        public Graphics graphics;
        public float CenterX { get; set; }
        public float CenterY { get; set; }

        public Figure(float x, float y)
        {
            graphics = Form1.ActiveForm.CreateGraphics();
            CenterX = x;
            CenterY = y;
        }

        public abstract void DrawBlack();

        public void HideDrawingBackGround()
        {
            graphics.Clear(Color.White);
        }

        public void MoveRight()
        {
            float counter = 1f;
            for (float i = 0; i < 20; i += counter)
            {
                CenterX += counter;
                HideDrawingBackGround();
                DrawBlack();
                System.Threading.Thread.Sleep(100);
            }
        }
    }
}
