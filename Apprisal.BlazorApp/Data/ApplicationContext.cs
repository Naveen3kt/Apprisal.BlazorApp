using Microsoft.EntityFrameworkCore;

namespace Apprisal.BlazorApp.Data
{

    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {

        }
        public DbSet<ApprisalEntity> Apprisals { get; set; } = default!;
        //public DbSet<UserEntryEntity> UsersEntries { get; set; } = default!;

    }
}
