using System;
using System.Collections.Generic;
using System.Linq;

namespace StocksBonanza.Core
{
    public class StocksManager
    {
        private List<StockCounter> _counters;

        public StocksManager()
        {
            _counters = new List<StockCounter>();
        }

        public void AddTransaction(
            string ticker,
            int stockCount,
            bool isBuy)
        {
            try
            {
                Console.WriteLine(ticker.Length);
                var counter = GetCounter(ticker);
                if (counter == null)
                {
                    counter = new StockCounter(ticker);
                    _counters.Add(counter);
                }
                else
                {
                    Console.WriteLine("A");
                }

                if (isBuy || stockCount <= counter.Count)
                {
                    counter.Count += stockCount;
                }
                else
                {
                    Console.WriteLine("B");
                }
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("C");
            }
        }

        private StockCounter GetCounter(string ticker)
        {
            return _counters.FirstOrDefault(sc => sc.StockTicker == ticker);
        }

        public int GetTotalCount(string ticker)
        {
            var counter = GetCounter(ticker);
            return counter?.Count ?? 0;
        }
    }
}
