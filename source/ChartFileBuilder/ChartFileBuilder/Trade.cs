using System;


namespace ChartFileBuilder
{
    internal class Trade
    {
        internal readonly string Symbol;
        internal readonly DateTime Date;
        internal readonly double ResultPercent;  

        internal Trade(string symbol, DateTime date, double resultPercent)
        {
            Symbol = symbol;
            Date = date;
            ResultPercent = resultPercent;
        }
    }
}
