using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public sealed class StudentCounter
    {

        private static StudentCounter instance = null;

        private StudentCounter() { }

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
    }
}
