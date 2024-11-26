﻿

namespace FactoryMethod;

public class ConsoleLogger : ILogger
{        
        public void Log(string message) => Console.WriteLine($"Console Logger: {message}");    
}