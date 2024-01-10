using _221229064_BilalEnes_Candemir_Proje.Entitites;
using Microsoft.EntityFrameworkCore;

namespace _221229064_BilalEnes_Candemir_Proje.Concrete
{
	public class SqlDbContext : DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Data Source=localhost,1433;Initial Catalog=sql;User ID=SA;Password=reallyStrongPwd123;TrustServerCertificate=true;");
		}

		public DbSet<Account> Accounts { get; set; }
	}
}
