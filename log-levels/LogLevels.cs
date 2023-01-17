using System;

static class LogLine
{
    public static string Message(string logLine)
    {
        int indexOfSquareBracket = logLine.IndexOf(' ');
        string message = logLine.Substring(indexOfSquareBracket, logLine.Length - indexOfSquareBracket).Trim();
        return message;
    }

    public static string LogLevel(string logLine)
    {
        int indexOfOpenSquareBracket = logLine.IndexOf('[');
        int indexOfClosedSquareBracket = logLine.IndexOf(']');
        string message = logLine.Substring(indexOfOpenSquareBracket + 1, indexOfClosedSquareBracket - 1).ToLower();
        return message;
    }

    public static string Reformat(string logLine)
    {
        int indexOfOpenSquareBracket = logLine.IndexOf('[');
        int indexOfClosedSquareBracket = logLine.IndexOf(']');
        int indexOfSquareBracket = logLine.IndexOf(' ');
        string messageBody = logLine.Substring(indexOfSquareBracket, logLine.Length - indexOfSquareBracket).Trim();
        string messageError = logLine.Substring(indexOfOpenSquareBracket + 1, indexOfClosedSquareBracket - 1).ToLower();
        string fullMessage = messageBody + $" ({messageError})";
        return fullMessage;
    }
}
