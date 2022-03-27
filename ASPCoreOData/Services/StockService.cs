using ASPCoreOData.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ASPCoreOData.Services
{
    public class StockService : IStockService
    {
        public IQueryable<Stock> GetStocks()
        {
            return new List<Stock>
            {
                new Stock{
                    Id = Guid.NewGuid(),
                    Ticker = "CBA",
                    Name = "Commonwealth Bank of Australia",
                    BuyingPrice = 92,
                    CurrentPrice = 106,
                    Quantity = 10,
                    Holdings=1
                },
                new Stock{
                    Id = Guid.NewGuid(),
                    Ticker = "BHP",
                    Name = "BHP Group Limited",
                    BuyingPrice = 42,
                    CurrentPrice = 49.77,
                    Quantity = 100,
                    Holdings=1
                },
                new Stock{
                    Id = Guid.NewGuid(),
                    Ticker = "ZIP",
                    Name = "Zip Co Limited",
                    BuyingPrice = 2.96,
                    CurrentPrice = 1.55,
                    Quantity = 1000,
                    Holdings=1
                },
                new Stock{
                    Id = Guid.NewGuid(),
                    Ticker = "APX",
                    Name = "Appen Limited",
                    BuyingPrice = 8.96,
                    CurrentPrice = 6.98,
                    Quantity = 200,
                    Holdings=1
                },
            }.AsQueryable();
        }
    }
}
