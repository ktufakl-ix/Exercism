// TODO: define the 'LogLevel' enum
using System.Reflection.Metadata.Ecma335;
using System.Text.RegularExpressions;
public enum LogLevel
{
    // Define the log levels here (e.g., Info, Warning, Error)
    Unknown = 0,
    Trace = 1,
    Debug = 2,
    Info = 4,
    Warning = 5,
    Error = 6,
    Fatal = 42,
}
static class LogLine
{
    public static LogLevel ParseLogLevel(string logLine)
    {
        string pattern = @"\[(.*?)\]";
        var res = Regex.Match(logLine, pattern);
        if(res.Success)
        {
            var lev = res.Groups[1].Value;
            switch(lev)
            {
                case "INF":
                    return LogLevel.Info;
                case "TRC":
                    return LogLevel.Trace;
                case "DBG":
                    return LogLevel.Debug;
                case "WRN":
                    return LogLevel.Warning;
                case "ERR":
                    return LogLevel.Error;
                case "FTL":
                    return LogLevel.Fatal;
                default:
                    return LogLevel.Unknown;
            }
        }
        return LogLevel.Unknown;
    }

    public static string OutputForShortLog(LogLevel logLevel, string message)
    {
        return $"{((int)logLevel)}:{message}";
    }
}
