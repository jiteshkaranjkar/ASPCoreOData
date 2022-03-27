using ASPCoreOData.Model;
using System.Linq;

namespace ASPCoreOData.Services
{
    public interface IStockService
    {
        public IQueryable<Stock> GetStocks();
    }
}
