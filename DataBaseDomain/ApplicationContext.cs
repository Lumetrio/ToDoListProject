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
			
            // System.InvalidOperationException: "The seed entity for entity type 'TaskEntity' cannot be added because a non-zero value is required for property 'Id'. Consider providing a negative value to avoid collisions with non-seed data."  

            Database.EnsureCreated();
		}
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			
		
		}
		public DbSet<TaskEntity> Tasks { get; set; } = null!;
		public DbSet<User> Users { get; set; } = null!;
		
	}
}
