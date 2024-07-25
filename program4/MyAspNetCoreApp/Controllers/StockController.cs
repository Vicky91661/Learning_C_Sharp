using Microsoft.AspNetCore.Mvc;
using MyAspNetCoreApp.Data;

namespace MyAspNetCoreApp.Controllers
{
    [Route("api/stock")]
    [ApiController]
    public class StockController:ControllerBase
    {
        private readonly ApplicationDBContext _context;
        public StockController(ApplicationDBContext context)
        {
            _context=context;
            
        }
        [HttpGet]

        public IActionResult GetAll(){
            var stocks = _context.Stocks.ToList();
            return Ok(stocks);
        }
    }
}