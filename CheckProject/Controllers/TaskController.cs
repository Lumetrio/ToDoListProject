
using DataBaseDomain;
using Domains.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CheckProject.Controllers
{
	public class TaskController : Controller
	{
		private readonly ILogger<TaskController> _logger;
		private readonly ApplicationContext _context;

		

		public TaskController(ILogger<TaskController> logger, ApplicationContext context)
		{
			_logger = logger;
			_context = context;
		}

		public async Task<IActionResult> Index()
		{
			await _context.Users.AddAsync(new User { Name = "top", Password = "1212415" });
			_context.Users.Add(new User { Name = "to12p", Password = "1214122415" });
			await _context.SaveChangesAsync();
			return View(_context.Users.ToList());
		}
		[HttpGet]
		public IActionResult Register()
		{
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> Register(Domains.Models.User user)
		{
			if (user.Name!="ehaeatawweata") {
				await _context.Users.AddAsync(user);
				_logger.LogInformation($"User was successfully added {user.Name} and {user.Password}");
				return RedirectToAction("Index");

			}
			return Content("There is a mistake");
		}
	}
}
