using Microsoft.AspNetCore.Mvc;
using Sushimi.Data;

namespace Sushimi.Controllers
{
    public class DrinksController : Controller
    {
		private readonly ILogger<DrinksController> _logger;
		private readonly ApplicationDbContext _context;

		public DrinksController(ILogger<DrinksController> logger, ApplicationDbContext context)
		{
			_logger = logger;
			_context = context;
		}

		public IActionResult Index()
		{
			try
			{
				var dishes = _context.Dishes.ToList();
				return View(dishes);
			}
			catch (Exception ex)
			{
				_logger.LogError(ex.Message);
				return StatusCode(500);
			}
		}
	}
}
