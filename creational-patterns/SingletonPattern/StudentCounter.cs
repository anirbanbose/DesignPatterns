using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public sealed class StudentCounter
    {
        private int _counter = 0;

        private static StudentCounter instance = null;

        private StudentCounter() 
        {
            Console.WriteLine($"Entered StudentCounter constructor for thread: {Thread.CurrentThread.ManagedThreadId}");
        }

        public static StudentCounter GetInstance()
        {
            if (instance == null)
            {
                instance = new StudentCounter();
            }
            return instance;
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
