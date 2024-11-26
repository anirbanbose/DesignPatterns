

namespace FactoryMethod;

public abstract class LoggerCreator
{
    public abstract ILogger CreateLogger();
}

public class ConsoleLoggerCreator : LoggerCreator
{
    public override ILogger CreateLogger() => new ConsoleLogger();
}

public class FileLoggerCreator : LoggerCreator
{
    public override ILogger CreateLogger() => new FileLogger();
}
