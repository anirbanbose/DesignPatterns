using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class Implementation
    {

        public static void StudentCounterImplementation()
        {
            var obj = StudentCounter.GetInstance();
            Console.WriteLine($"Current student counter value: {obj.Counter}, object Hashcode: {obj.ToString()}, and Thread Id: {Thread.CurrentThread.ManagedThreadId}");
        }

        public static void ThreadsafeStudentCounterImplementation()
        {
            var obj = ThreadSafeStudentCounter.GetInstance();
            Console.WriteLine($"Current counter value: {obj.Counter}, thread-safe object Hashcode: {obj.ToString()}, and Thread Id: {Thread.CurrentThread.ManagedThreadId}");
        }

    }
}
