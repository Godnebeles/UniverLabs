using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyTimer
{
    public class MyTimer
    {
        public FixedUpdate fixedUpdate;
        private bool _isRunning = false;
        private int _delay;

        public MyTimer(int delay)
        {
            _delay = delay;
        }

        public void Start()
        {
            _isRunning = true;
            Ticker();
        }

        public void Stop()
        {
            _isRunning = false;
        }

        private void Ticker()
        {
            while (_isRunning)
            {
                fixedUpdate(new Random().Next(5, 15));

                Thread.Sleep(_delay);
            }
        }
    }
}
