namespace ChartFileBuilder
{
    internal class TradeDispalyInfo
    {
        internal readonly string Symbol;
        internal readonly string Date;
        internal readonly string Type;
        internal readonly int WeekBaseCount;
        internal readonly double ResultPercent;  

        internal TradeDispalyInfo(string symbol, string date, string type, int weekBaseCount, double resultPercent)
        {
            Symbol = symbol;
            Date = date;
            Type = type;
            WeekBaseCount = weekBaseCount;
            ResultPercent = resultPercent;
        }
    }
}
