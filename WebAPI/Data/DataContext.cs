
namespace WebAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        {
        
        }

        public DbSet<Character> Characters => Set<Character>();
        public DbSet<User> Users => Set<User>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Character>()
                .Property(c => c.Id)
                .HasDefaultValueSql("NEWID()"); // Or use "NEWSEQUENTIALID()" if preferred
            modelBuilder.Entity<User>()
                .Property(c => c.Id)
                .HasDefaultValueSql("NEWID()");
        }

    }
}
