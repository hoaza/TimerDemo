using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;

namespace TimerDemo
{
    public delegate void ExpiredEventHandler(DateTime signaledTime);


    public class Timer
    {
        private const int DEFAULT_INTERVAL = 1000;
        private readonly Thread ticker;

        public Timer()
        {
            this.ticker = new Thread(OnTick);
        }

        public event ExpiredEventHandler Expired;

        public int Interval { get; set; } = DEFAULT_INTERVAL;

        public void Start() => this.ticker.Start();

        private void OnTick()
        {
            while (true)
            {
                Thread.Sleep(this.Interval);
                Expired?.Invoke(DateTime.Now);
            }
        }
    }
}
