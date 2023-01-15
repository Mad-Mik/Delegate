using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            FreeDay freeday = new FreeDay();
            int time;
            Action1 action = new Action1(freeday.Eat);
            action += freeday.Smoking;
            action += freeday.WatchTv;
            action += freeday.Sleep;

            action.Invoke();

            Day day = new Day();
            Action2 delegateday = new Action2(day.EatTime);
            delegateday += day.SmokingTime;
            delegateday += day.WatchTvTime;
            delegateday += day.SleepTime;

            delegateday.Invoke(out time);
            Console.WriteLine(time);
            delegateday.Invoke(out time);

            Console.ReadLine();
        }
    }
}






