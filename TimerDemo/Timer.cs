using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;

namespace TimerDemo
{
    public class Timer
    {
        private Thread ticker;

        public Timer()
        {
            this.ticker = new Thread(OnTick);
        }

        public void Start() => this.ticker.Start();

        private void OnTick()
        {
            while (true)
            {
                Thread.Sleep(1000);
                Console.WriteLine("Timer elapsed!");
            }
        }
    }
}
