using System;

namespace TimerDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Timer timer = new Timer
            {
                Interval = 2000
            };

            timer.Expired += (DateTime dateTime) => Console.WriteLine($"Timer elapsed {dateTime}");

            timer.Start();
        }
    }
}
