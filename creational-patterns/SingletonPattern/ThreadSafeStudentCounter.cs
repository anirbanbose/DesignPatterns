using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public sealed class ThreadSafeStudentCounter
    {

        private static readonly Lazy<ThreadSafeStudentCounter> instance = new Lazy<ThreadSafeStudentCounter>(() => new ThreadSafeStudentCounter());

        private ThreadSafeStudentCounter() { }

        public static ThreadSafeStudentCounter GetInstance()
        {
            return instance.Value;
        }


        public override string ToString()
        {
            return GetHashCode().ToString();
        }
    }
}
