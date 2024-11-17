using Domains.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseDomain
{
	public class ApplicationContext : DbContext
	{
		public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
		{
			
			Database.EnsureDeleted();
			
			Database.EnsureCreated();
			
		}
		public DbSet<TaskEntity> Tasks { get; set; } = null!;
		public DbSet<User> Users { get; set; } = null!;
		
	}
}
