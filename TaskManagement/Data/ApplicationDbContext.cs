using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using System.Reflection.Emit;
using TaskManagement.Entities;

namespace TaskManagement.Data
{
    public class ApplicationDbContext : IdentityDbContext<User, Role, int>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public DbSet<TblComment> Comments { get; set; }
        public DbSet<TblDmDepartment> Departments { get; set; }
        public DbSet<TblFailedJob> FailedJobs { get; set; }
        public DbSet<TblJob> Jobs { get; set; }
        public DbSet<Entities.TblDmLabel> Labels { get; set; }
        public DbSet<Entities.TblTask> Tasks { get; set; }
        public DbSet<TaskLabel> TaskLabels { get; set; }
        public DbSet<TaskUser> TaskUsers { get; set; }
        //public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(builder);

            #region ASP.NET Core Identity Tables
            builder.Entity<User>().ToTable("Users").HasKey(x => x.Id);

            builder.Entity<Role>(entity =>
            {
                entity.ToTable("Roles");
            });
            builder.Entity<IdentityUserRole<int>>(entity =>
            {
                entity.ToTable("UserRoles");
            });

            builder.Entity<IdentityUserClaim<int>>(entity =>
            {
                entity.ToTable("UserClaims");
            });

            builder.Entity<IdentityUserLogin<int>>(entity =>
            {
                entity.ToTable("UserLogins");
                entity.HasIndex(x => x.ProviderKey);
            });

            builder.Entity<IdentityRoleClaim<int>>(entity =>
            {
                entity.ToTable("RoleClaims");
            });

            builder.Entity<IdentityUserToken<int>>(entity =>
            {
                entity.ToTable("UserTokens");
            });
            #endregion
        }
    }
}
