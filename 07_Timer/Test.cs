using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _07_Timer.Models
{
    class Test
    {
        static void Main(string[] args)
        {
            TimeTicker ticker = new TimeTicker(Timer.startAction);

            for (int cycles = 1; cycles <= 10; cycles++)
            {
                Thread.Sleep(1000);
                ticker();
            }
        }
    }
}
