
namespace MVC.Services
{
    public class SimpleFileLogger : ILogger
    {
        public IDisposable BeginScope<TState>(TState state) => null;

        public bool IsEnabled(LogLevel logLevel)
        {
            return true;
        }

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception? exception, Func<TState, Exception?, string> formatter)
        {
            if (!IsEnabled(logLevel)) return;
            var message = formatter(state, exception);
            File.AppendAllText("log.txt", $"[{logLevel}] : {message}"); 
        }
        public void Log(string message)
        {
            File.AppendAllText("log.txt", message);
        }
            
    }
}
