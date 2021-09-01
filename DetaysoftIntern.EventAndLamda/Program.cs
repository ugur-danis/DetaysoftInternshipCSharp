using System;
using System.Threading;

namespace DetaysoftIntern.Event
{
    class Program
    {
        static void Main(string[] args)
        {
            Counter counter = new(5, 1);
            counter.CountdownStartEvent = () => Console.WriteLine("Counter is start.");
            counter.CountdownRunTimeEvent = () =>
            {
                Console.WriteLine("Counter is run {0}", counter.GetCountdown);
            };
            counter.CountdownEndEvent = () => Console.WriteLine("Counter is end.");
            counter.CountdownStart();
        }
    }

    class Counter
    {
        public int Countdown { get; set; }
        public int Interval { get; set; }
        public Action CountdownStartEvent { get; set; }
        public Action CountdownRunTimeEvent { get; set; }
        public Action CountdownEndEvent { get; set; }
        public int GetCountdown { get; private set; }

        public Counter(int countdown, int interval)
        {
            Countdown = countdown;
            Interval = interval * 1000;
        }

        public void CountdownStart()
        {
            CountdownStartEvent();
            CountdownRun();
        }


        private void CountdownRun()
        {
            for (int i = Countdown - 1; i >= 0; i--)
            {
                GetCountdown = i;
                CountdownRunTimeEvent();
                Thread.Sleep(Interval);
            }
            CountdownEndEvent();
        }
    }
}
