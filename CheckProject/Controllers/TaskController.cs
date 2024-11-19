
using DataBaseDomain;
using Domains.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace CheckProject.Controllers
{
	// мб каким-нибудь образом по пользователям посмотреть их задачи
	//var tasks=_context.tasks.Include(u=>u.User) подгрузим тогда их связь
	public class TaskController : Controller
	{
		private readonly ILogger<TaskController> _logger;
		private readonly ApplicationContext _context;

		

		public TaskController(ILogger<TaskController> logger, ApplicationContext context)
		{
			_logger = logger;
			_context = context;
		
		}
		private async Task<IActionResult> Partial()
		{
			List<TaskEntity> data = await _context.Tasks.ToListAsync();
			return PartialView(data);
		}
		public IActionResult GetShitDone()
		{
			
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> GetShitDone(TaskEntity task)
		{//сделай так чтобы даанные появлялись в бд
            if (ModelState.IsValid)
            {
                await _context.Tasks.AddAsync(task);
                await _context.SaveChangesAsync();
                // Возвращаем обновлённый список задач
                var tasks = await _context.Tasks.ToListAsync();
				return PartialView("Partial", tasks);

			}
			return BadRequest("Некорректные данные.");
        }

		public IActionResult UserPage()
		{
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
