// See https://aka.ms/new-console-template for more information
using SingletonPattern;

Console.WriteLine("Hello, World!");


Parallel.Invoke(
    () => Implementation.StudentCounterImplementation(),
    () => Implementation.StudentCounterImplementation(),
    () => Implementation.StudentCounterImplementation(),
    () => Implementation.StudentCounterImplementation(),
    () => Implementation.StudentCounterImplementation(),
    () => Implementation.StudentCounterImplementation()
    );

Parallel.Invoke(
    () => Implementation.ThreadsafeStudentCounterImplementation(),
    () => Implementation.ThreadsafeStudentCounterImplementation(),
    () => Implementation.ThreadsafeStudentCounterImplementation(),
    () => Implementation.ThreadsafeStudentCounterImplementation(),
    () => Implementation.ThreadsafeStudentCounterImplementation(),
    () => Implementation.ThreadsafeStudentCounterImplementation()
    );



