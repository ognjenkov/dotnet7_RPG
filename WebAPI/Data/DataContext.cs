
namespace WebAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        {
        
        }

        public DbSet<Character> Characters => Set<Character>();
        public DbSet<User> Users => Set<User>();
        public DbSet<Weapon> Weapons => Set<Weapon>();
        public DbSet<Skill> Skills => Set<Skill>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Character>()
                .Property(c => c.Id)
                .HasDefaultValueSql("NEWID()"); // Or use "NEWSEQUENTIALID()" if preferred
            modelBuilder.Entity<User>()
                .Property(u => u.Id)
                .HasDefaultValueSql("NEWID()");
            modelBuilder.Entity<Weapon>()
                .Property(w => w.Id)
                .HasDefaultValueSql("NEWID()");
            modelBuilder.Entity<Skill>()
                .Property(s => s.Id)
                .HasDefaultValueSql("NEWID()");

            modelBuilder.Entity<Skill>().HasData(
                new Skill { Id = Guid.NewGuid(), Name = "Fireball", Damage =30 },
                new Skill { Id = Guid.NewGuid(), Name = "Frenzy", Damage =10 },
                new Skill { Id = Guid.NewGuid(), Name = "Blizzard", Damage =20 }
            );
        }

    }
}
