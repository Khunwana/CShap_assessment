using Microsoft.EntityFrameworkCore;
using Assessment.Models;

namespace Assessment
{
    public class SqliteDbContext : DbContext
    {

        //entities representing tables in the database
        public DbSet<Account> GuidInfos { get; set; }
		
		public SqliteDbContext(DbContextOptions<SqliteDbContext> options) : base(options)
        { 
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}