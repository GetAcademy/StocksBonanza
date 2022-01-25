using System;
using NUnit.Framework;
using StocksBonanza.Core;

namespace StocksBonanza.Test
{
    public class StocksManagerTest
    {
        [Test]
        public void TestSimpleCount()
        {
            var stocksManager = new StocksManager();
            stocksManager.AddTransaction("DNB", 5, true);
            var count = stocksManager.GetTotalCount("DNB");
            Assert.AreEqual(5, count);
        }

        [Test]
        public void TestSimpleCount2()
        {
            var stocksManager = new StocksManager();
            stocksManager.AddTransaction("DNB", 2, true);
            stocksManager.AddTransaction("DNB", 2, true);
            var count = stocksManager.GetTotalCount("DNB");
            Assert.AreEqual(4, count);
        }


        [Test]
        public void TestTwoStocks()
        {
            var stocksManager = new StocksManager();
            stocksManager.AddTransaction("DNB", 2, true);
            stocksManager.AddTransaction("YAR", 3, true);
            var countDnb = stocksManager.GetTotalCount("DNB");
            var countYara = stocksManager.GetTotalCount("YAR");
            Assert.AreEqual(2, countDnb);
            Assert.AreEqual(3, countYara);
        }

        [Test]
        public void TestGettingCountOfNewStock()
        {
            var stocksManager = new StocksManager();
            var countDnb = stocksManager.GetTotalCount("DNB");
            Assert.AreEqual(0, countDnb);
        }

        [Test]
        public void TestSimpleCount5()
        {
            var stocksManager = new StocksManager();
            stocksManager.AddTransaction("DNB", 2, false);
            var countDnb = stocksManager.GetTotalCount("DNB");
            Assert.AreEqual(0, countDnb);
        }

        /* Code coverage, ignore above */
        [Test]
        public void TestCodeCoverage1()
        {
            var stocksManager = new StocksManager();
            stocksManager.AddTransaction("DNB", 5, true);
            var count = stocksManager.GetTotalCount("DNB");
            Assert.AreEqual(5, count);
        }

        [Test]
        public void TestCodeCoverage2()
        {
            var stocksManager = new StocksManager();
            stocksManager.AddTransaction("DNB", 5, true);
            stocksManager.AddTransaction("DNB", 5, true);
            var count = stocksManager.GetTotalCount("DNB");
            Assert.AreEqual(5, count);
        }

        [Test]
        public void TestCodeCoverage3()
        {
            var stocksManager = new StocksManager();
            stocksManager.AddTransaction("DNB", 2, false);
            var countDnb = stocksManager.GetTotalCount("DNB");
            Assert.AreEqual(0, countDnb);
        }

        [Test]
        public void TestCodeCoverage4()
        {
            var stocksManager = new StocksManager();
            //Assert.Throws<NullReferenceException>(() => stocksManager.AddTransaction(null, 2, false));
            stocksManager.AddTransaction(null, 2, false);
        }
    }
}