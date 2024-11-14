using Domains.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseDomain
{
	public class BaseRepository : IBaseRepository<TaskEntity>
	{
		private readonly ApplicationContext _context;

		public BaseRepository(ApplicationContext context)
		{
			_context = context;
		}

		public async Task Create(TaskEntity entity)
		{
			await _context.Tasks.AddAsync(entity);
			await _context.SaveChangesAsync();
		}

		public async Task Delete(TaskEntity entity)
		{
			 _context.Tasks.Remove(entity);
			await _context.SaveChangesAsync();
		}

		public IQueryable<TaskEntity> GetAll()
		{
			return _context.Tasks;
		}

		public async Task<TaskEntity> Update(TaskEntity entity)
		{
			_context.Tasks.Update(entity);
			await _context.SaveChangesAsync();
			return entity;
		}
	}
}
