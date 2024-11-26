
using FactoryMethod;

LoggerCreator consoleLoggerCreator = new ConsoleLoggerCreator();
ILogger consoleLogger = consoleLoggerCreator.CreateLogger();
consoleLogger.Log($"This log message has been created on {DateTime.Now.ToString()}.");

LoggerCreator fileLoggerCreator = new FileLoggerCreator();
ILogger fileLogger = fileLoggerCreator.CreateLogger();
fileLogger.Log($"This log message has been created on {DateTime.Now.ToString()}.");
