using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Timer.Models
{
    public delegate void TimeTicker();

    public static class Timer
    {
        private static int seconds = 0;

        public static int Seconds
        {
            get
            {
                return seconds;
            }

            private set
            {
                seconds = value;
            }
        }

        public static Action startAction = new Action(() => Console.WriteLine(++Seconds));
    }
}
