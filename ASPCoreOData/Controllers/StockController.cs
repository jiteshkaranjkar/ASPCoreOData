using ASPCoreOData.Model;
using ASPCoreOData.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using System.Linq;

namespace ASPCoreOData.Controllers
{
    [ApiController]
    [Route("api/stocks")]
    public class StocksController : Controller
    {
        private IStockService stockService;

        public StocksController(IStockService stockService) =>
            this.stockService = stockService;

        // GET: StocksController
        [HttpGet]
        [EnableQuery]
        public ActionResult<IQueryable<Stock>> Get()
        {
            IQueryable<Stock> stocks = stockService.GetStocks();
            return Ok(stocks);
        }
    }
}
