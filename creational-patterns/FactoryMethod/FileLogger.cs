

namespace FactoryMethod;

public class FileLogger : ILogger
{
    public void Log(string message) => System.IO.File.AppendAllText("log.txt", $"File Logger: {message}\n");
}
