using System;
using System.Diagnostics;

enum LogLevel
{
    Trace,
    Debug,
    Info,
    Warning,
    Error,
    Fatal,
    Unknown
}

static class LogLine
{
    public static LogLevel ParseLogLevel(string logLine) // always "[<LVL>]: <MESSAGE>"
    {
        switch (logLine.Substring(1, 3))
        {
            case "TRC":
                return LogLevel.Trace;
            case "DBG":
                return LogLevel.Debug;
            case "INF":
                return LogLevel.Info;
            case "WRN":
                return LogLevel.Warning;
            case "ERR":
                return LogLevel.Error;
            case "FTL":
                return LogLevel.Fatal;
            default:
                return LogLevel.Unknown;
        };
    }

    public static string OutputForShortLog(LogLevel logLevel, string message)
    {
        throw new NotImplementedException("Please implement the (static) LogLine.OutputForShortLog() method");
    }
}
