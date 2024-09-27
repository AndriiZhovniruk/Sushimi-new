using Microsoft.AspNetCore.Mvc;
using Sushimi.Data;

namespace Sushimi.Controllers
{
	public class SetsController : Controller
	{
		private readonly ILogger<SetsController> _logger;
		private readonly ApplicationDbContext _context;

		public SetsController(ILogger<SetsController> logger, ApplicationDbContext context)
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
