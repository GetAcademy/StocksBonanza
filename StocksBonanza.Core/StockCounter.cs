namespace StocksBonanza.Core
{
    internal class StockCounter
    {
        public string StockTicker { get; }
        public int Count { get; set; }

        public StockCounter(string stockTicker)
        {
            StockTicker = stockTicker;
        }
    }
}
