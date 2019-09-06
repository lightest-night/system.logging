using Microsoft.Extensions.Logging;

namespace LightestNight.System.Logging.Extends
{
    public static class ExtendsLogLevel
    {
        public static bool IsError(this LogLevel logLevel)
            => logLevel == LogLevel.Critical || logLevel == LogLevel.Error || logLevel == LogLevel.Warning;
    }
}