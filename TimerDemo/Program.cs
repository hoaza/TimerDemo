using System;

namespace TimerDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Timer timer = new Timer
            {
                Interval = 0_500
            };

            ExpiredEventHandler expiredEvent = dateTime => Console.WriteLine($"Timer elapsed on {dateTime:HH:mm:ss.fff}");

            timer.Expired += expiredEvent;
            timer.Expired += expiredEvent;

            timer.Expired -= expiredEvent;

            //timer.Expired += Timer_Expired;

            timer.Start();
        }

        private static void Timer_Expired(DateTime signaledTime)
        {
            Console.WriteLine($"Timer(2) elapsed on {signaledTime:HH:mm:ss.fff}");
        }
    }
}
