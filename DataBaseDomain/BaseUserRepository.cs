using Domains.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseDomain
{
	public class BaseUserRepository : IBaseRepository<User>
	{
		private readonly ApplicationContext _context;

		public BaseUserRepository(ApplicationContext context)
		{
			_context = context;
		}

		public async Task Create(User user)
		{
			await _context.Users.AddAsync(user);
			await _context.SaveChangesAsync();	
		}

		public async Task Delete(User user)
		{
			_context.Users.Remove(user);
			await _context.SaveChangesAsync();
		}

		public IQueryable<User> GetAll()
		{
			return _context.Users;
		}

		public async Task<User> Update(User user)
		{
			_context.Users.Update(user);
			await _context.SaveChangesAsync();
			return user;
		}
	}
}
