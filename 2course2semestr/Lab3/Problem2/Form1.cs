using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Problem2
{
    public delegate void SuperButton();

    public partial class Form1 : Form
    {
        private int _colorIterator = 0;
        private Color[] _colors = { Color.Aqua, Color.Coral, Color.Pink, Color.Wheat};
        private SuperButton? _buttons;

        public Form1()
        {
            InitializeComponent();
        }

        public void ChangeOpacity() => Opacity = Opacity == 0.5 ? 1 : 0.5;
        public void ChangeColor()
        {
            BackColor = _colors[_colorIterator];
            _colorIterator = (_colorIterator + 1) % _colors.Length;
        }
        public void HelloWorld() => MessageBox.Show("Hello, !");



        private void button1_Click(object sender, EventArgs e)
        {
            ChangeOpacity();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChangeColor();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HelloWorld();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Я супермен!");
        }

        private void Invoker(object sender, EventArgs e)
        {
            _buttons?.Invoke();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                _buttons += ChangeOpacity;
            else
                _buttons -= ChangeOpacity;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
                _buttons += ChangeColor;
            else
                _buttons -= ChangeColor;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
                _buttons += HelloWorld;
            else
                _buttons -= HelloWorld;
        }
    }
}
