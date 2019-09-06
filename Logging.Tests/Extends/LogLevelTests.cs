using LightestNight.System.Logging.Extends;
using Microsoft.Extensions.Logging;
using Shouldly;
using Xunit;

namespace LightestNight.System.Logging.Tests.Extends
{
    public class LogLevelTests
    {
        [Theory]
        [InlineData(LogLevel.Critical, true)]
        [InlineData(LogLevel.Error, true)]
        [InlineData(LogLevel.Warning, true)]
        [InlineData(LogLevel.Debug, false)]
        [InlineData(LogLevel.Information, false)]
        [InlineData(LogLevel.None, false)]
        [InlineData(LogLevel.Trace, false)]
        public void Should_Denote_If_IsError_Correctly(LogLevel logLevel, bool expected)
        {
            // Act
            var result = logLevel.IsError();
            
            // Assert
            result.ShouldBe(expected);
        }
    }
}