using Microsoft.EntityFrameworkCore;

namespace UserManagement.Models
{
	public class UserManagementContext : DbContext
	{
		public DbSet<User> Users { get; set; }
		public DbSet<Admin> Admins { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseMySql("server=localhost;port=3306;database=user_management;user=root;password=root;", new MySqlServerVersion(new Version(8, 0, 36)));
		}
	}
}



