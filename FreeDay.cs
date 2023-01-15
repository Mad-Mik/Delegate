using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public delegate void Action1();
    public class FreeDay
    {
        public void Eat()
        {
            Console.WriteLine("eat");
        }

        public void Smoking()
        {
            Console.WriteLine("smoking");
        }

        public void WatchTv()
        {
            Console.WriteLine("watchtv");
        }

        public void Sleep()
        {
            Console.WriteLine("sleep");
        }

    }
}
