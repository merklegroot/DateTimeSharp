using System;

namespace DateTimeSharp
{
    public static class TimeSpanExtensions
    {
        public static string ToReadableValue(this TimeSpan timeSpan)
        {
            return $"{timeSpan.Hours}h {timeSpan.Minutes}m {timeSpan.Seconds}s";
        }
    }
}
