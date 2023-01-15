using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public delegate int Action2(out int a);
    internal class Day
    {
        public int EatTime(out int a)
        {
            a = 8;
            Console.WriteLine(a -= 1);
            return a;
        }

        public int SmokingTime(out int a)
        {
            a = EatTime(out a);
            Console.WriteLine(a -= 2);
            return a;
        }

        public int WatchTvTime(out int a)
        {
            a = SmokingTime(out a);
            Console.WriteLine(a -= 3);
            return a;
        }

        public int SleepTime(out int a)
        {
            a = WatchTvTime(out a);
            Console.WriteLine(a -= 4);
            return a;
        }
    }
}
