// See https://aka.ms/new-console-template for more information
using SingletonPattern;

Console.WriteLine("Hello, World!");



Parallel.Invoke(
    () => Implementation.ThreadsafeStudentCounterImplementation1(),
    () => Implementation.ThreadsafeStudentCounterImplementation2(),
    () => Implementation.ThreadsafeStudentCounterImplementation3(),
    () => Implementation.ThreadsafeStudentCounterImplementation4(),
    () => Implementation.ThreadsafeStudentCounterImplementation5(),
    () => Implementation.ThreadsafeStudentCounterImplementation6()
    );




Parallel.Invoke(
    () => Implementation.NormalStudentCounterImplementation1(),
    () => Implementation.NormalStudentCounterImplementation2(),
    () => Implementation.NormalStudentCounterImplementation3(),
    () => Implementation.NormalStudentCounterImplementation4(),
    () => Implementation.NormalStudentCounterImplementation5(),
    () => Implementation.NormalStudentCounterImplementation6()
    );