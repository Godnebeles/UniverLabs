using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MazeRenderWF
{ 
    public partial class Form1 : Form
    {
        private Graph _graph;
        private WithTimerRenderer _renderer;

        private Graphics _graphics;
        private Bitmap _bm;

        public Form1()
        {
            InitializeComponent();

            _bm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            _graphics = Graphics.FromImage(_bm);     
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = "labr.txt";

            _graph = new Graph("*", ".", "S", path);

            _renderer = new WithTimerRenderer(_graphics, _graph.Bfs());

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bool endRender = _renderer.ShowPathLengths();
                
            pictureBox1.Image = _bm;

            if (endRender)
            {
                _renderer.ShowShortestPath();
                timer1.Stop();
            }
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        
    }
}
