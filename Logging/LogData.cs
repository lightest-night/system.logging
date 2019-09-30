using System;
using LightestNight.System.Utilities;
using Microsoft.Extensions.Logging;

namespace LightestNight.System.Logging
{
    public class LogData
    {
        /// <summary>
        /// A succinct title of this Log
        /// </summary>
        public string Title { get; set; }
        
        /// <summary>
        /// The full message of this Log
        /// </summary>
        public string Message { get; set; }
        
        /// <summary>
        /// The function that raised this Log
        /// </summary>
        public string Function { get; set; }
        
        /// <summary>
        /// The version of the function that raised this Log
        /// </summary>
        public string FunctionVersion { get; set; }
        
        /// <summary>
        /// Any hosting region this Log was raised within
        /// </summary>
        public string Region { get; set; }
        
        /// <summary>
        /// A descriptor of the type of this Log
        /// </summary>
        public string Type { get; set; }
        
        /// <summary>
        /// The Severity of this Log
        /// </summary>
        public LogLevel Severity { get; set; }
        
        /// <summary>
        /// When this occurred, as a unix timestamp.
        /// </summary>
        public long Timestamp { get; set; }

        /// <summary>
        /// When this occurred, as a UTC date
        /// </summary>
        public DateTime Datestamp => DateTimeOffset.FromUnixTimeSeconds(Timestamp).UtcDateTime;
        
        /// <summary>
        /// Any Request Identifier to include with this Log
        /// </summary>
        public string RequestId { get; set; }
        
        /// <summary>
        /// The <see cref="ErrorType" /> of this Log
        /// </summary>
        public ErrorType ErrorType { get; set; }
        
        /// <summary>
        /// The Environment this Log occurred within
        /// </summary>
        public string Environment { get; set; }
        
        /// <summary>
        /// Any Exception being logged
        /// </summary>
        public LightestNightException Exception { get; set; }
    }
}