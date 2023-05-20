using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Bases.DbContexts
{
    public class BaseDbContext : DbContext
    {

        #region Properties



        #endregion

        #region Constructors

        protected BaseDbContext(DbContextOptions options) : base(options) {}

        public BaseDbContext(DbContextOptions<BaseDbContext> options) : base(options) { }

        #endregion

        #region Methods

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .LogTo(x => Console.WriteLine(x))
                .EnableSensitiveDataLogging();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(BaseDbContext).Assembly);

            base.OnModelCreating(modelBuilder);
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder
                .DefaultTypeMapping<string>()
                .IsUnicode(false)
                .HasMaxLength(200);

            base.ConfigureConventions(configurationBuilder);
        }

        #endregion

    }
}
