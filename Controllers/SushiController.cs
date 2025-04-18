﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sushimi.Data;
using Sushimi.Models;

namespace Sushimi.Controllers
{
	public class SushiController : Controller
	{
		private readonly ILogger<SushiController> _logger;
		private readonly ApplicationDbContext _context;

		public SushiController(ILogger<SushiController> logger, ApplicationDbContext context)
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
