using LeaveManagement.Data.Configuration.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagement.Data
{
    public class ApplicationDbContext : IdentityDbContext<Employee>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new RoleSeedConfiguration()); //rolleri db ye ekle
            builder.ApplyConfiguration(new UserSeedConfiguration()); //admin ve bi tane user i db ye ekle
            builder.ApplyConfiguration(new UserRoleSeedConfiguration()); //admin e admin rolu, user a user rolu verdik
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            foreach (var entry in base.ChangeTracker.Entries<BaseEntity>().Where(q => q.State == EntityState.Modified || q.State == EntityState.Added))
            {
                entry.Entity.DateModified = DateTime.Now;

                if(entry.State == EntityState.Added)
                {
                    entry.Entity.DateCreated = DateTime.Now;
                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }

        public DbSet<LeaveType> LeaveTypes { get; set; }
        public DbSet<LeaveAllocation> LeaveAllocations{ get; set; }
        public DbSet<LeaveRequest> LeaveRequests{ get; set; }
    }
}