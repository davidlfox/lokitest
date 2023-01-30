using NLog;

internal class Program
{
    private const string app = "lokipoc-service";

    private static void Main(string[] args)
    {
        var logger = LogManager.GetCurrentClassLogger();
        logger.Info("inside lokipoc");

        logger.Trace("trace message", new { app });
        logger.Debug("debug message", new { app });
        logger.Warn("warn message", new { app });
        logger.Error("error message", new { app });
        logger.Fatal("fatal message", new { app });

        Console.WriteLine("done");
    }
}
