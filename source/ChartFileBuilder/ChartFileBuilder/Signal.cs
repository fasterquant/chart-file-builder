using System;


namespace ChartFileBuilder
{
    internal class Signal
    {
        internal readonly string Symbol;
        internal readonly DateTime Date;
        internal readonly string Type;
        internal readonly int WeekBaseCount;

        internal Signal(string symbol, DateTime date, string type, int weekBaseCount)
        {
            Symbol = symbol;
            Date = date;
            Type = type;
            WeekBaseCount = weekBaseCount;
        }
    }
}
