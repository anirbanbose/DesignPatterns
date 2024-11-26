using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public sealed class ThreadSafeStudentCounter
    {
        private int _counter = 0;

        private static readonly Lazy<ThreadSafeStudentCounter> instance = new Lazy<ThreadSafeStudentCounter>(() => new ThreadSafeStudentCounter());

        private ThreadSafeStudentCounter()
        {
            Console.WriteLine($"Entered ThreadSafeStudentCounter constructor for thread: {Thread.CurrentThread.ManagedThreadId}");
        }

        public static ThreadSafeStudentCounter GetInstance()
        {
            return instance.Value;
        }


        public override string ToString()
        {
            return GetHashCode().ToString();
        }
        public int Counter
        {
            get
            {
                _counter++;
                return _counter;
            }
        }
    }
}
