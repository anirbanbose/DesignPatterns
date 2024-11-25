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
        public static void ThreadsafeStudentCounterImplementation1()
        {
            Console.WriteLine($"Current thread-safe object Hashcode: {ThreadSafeStudentCounter.GetInstance().ToString()}");
        }
        public static void ThreadsafeStudentCounterImplementation2()
        {
            Console.WriteLine($"Current thread-safe object Hashcode: {ThreadSafeStudentCounter.GetInstance().ToString()}");
        }
        public static void ThreadsafeStudentCounterImplementation3()
        {
            Console.WriteLine($"Current thread-safe object Hashcode: {ThreadSafeStudentCounter.GetInstance().ToString()}");
        }
        public static void ThreadsafeStudentCounterImplementation4()
        {
            Console.WriteLine($"Current thread-safe object Hashcode: {ThreadSafeStudentCounter.GetInstance().ToString()}");
        }
        public static void ThreadsafeStudentCounterImplementation5()
        {
            Console.WriteLine($"Current thread-safe object Hashcode: {ThreadSafeStudentCounter.GetInstance().ToString()}");
        }
        public static void ThreadsafeStudentCounterImplementation6()
        {
            Console.WriteLine($"Current thread-safe object Hashcode: {ThreadSafeStudentCounter.GetInstance().ToString()}");
        }


        public static void NormalStudentCounterImplementation1()
        {
            Console.WriteLine($"Current normal object Hashcode: {StudentCounter.GetInstance().ToString()}");
        }
        public static void NormalStudentCounterImplementation2()
        {
            Console.WriteLine($"Current normal object Hashcode: {StudentCounter.GetInstance().ToString()}");
        }
        public static void NormalStudentCounterImplementation3()
        {
            Console.WriteLine($"Current normal object Hashcode: {StudentCounter.GetInstance().ToString()}");
        }
        public static void NormalStudentCounterImplementation4()
        {
            Console.WriteLine($"Current normal object Hashcode: {StudentCounter.GetInstance().ToString()}");
        }
        public static void NormalStudentCounterImplementation5()
        {
            Console.WriteLine($"Current normal object Hashcode: {StudentCounter.GetInstance().ToString()}");
        }
        public static void NormalStudentCounterImplementation6()
        {
            Console.WriteLine($"Current normal object Hashcode: {StudentCounter.GetInstance().ToString()}");
        }
    }
}
