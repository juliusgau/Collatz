﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace Collatz
{
    class Program
    {
        List<long> list;
        long i;
        Stopwatch sw;
        static void Main(string[] args)
        {
            Program p = new Program();
        }

        Program()
        {
            Stopwatch sw = new Stopwatch();
            list = new List<long>();
            i = long.MaxValue-1;
            list.Add(i);

            sw.Start();
            for (int k = 0; k < 10; k++)
            {
                for (long j = 1; j < 100000; j++)
                {
                    i = j;
                    while (i != 1)
                    {
                        i = Calc_Collatz(i);
                        //list.Add(i);
                    }
                }
            }
            sw.Stop();

            double ticks = sw.ElapsedTicks;
            double seconds = ticks / Stopwatch.Frequency;
            double milliseconds = (ticks / Stopwatch.Frequency) * 1000;
            double nanoseconds = (ticks / Stopwatch.Frequency) * 1000000000;
            foreach (int number in list)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine(milliseconds/10);
            Console.Read();
        }

        long Calc_Collatz(long i)
        {
            if(i%2==1)
            {
                return ((3 * i) + 1) / 2;
            }
            else if (i==1)
            {
                return 1;
            }
            else if(i%2 == 0)
            {
                return i / 2;
            }
            else
            {
                return (3 * i) + 1;
            }
        }
    }
}
