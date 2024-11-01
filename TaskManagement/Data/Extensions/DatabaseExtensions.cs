using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TaskManagement.Entities;
using Task = System.Threading.Tasks.Task;

namespace TaskManagement.Data.Extensions
{
    public static class DatabaseExtensions
    {
        public static async Task InitialiseDatabaseAsync(this WebApplication app, IServiceProvider serviceProvider)
        {
            using var scope = app.Services.CreateScope();

            var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
            
            context.Database.MigrateAsync().GetAwaiter().GetResult();

            await SeedAsync(context, serviceProvider);
        }

        private static async Task SeedAsync(ApplicationDbContext context, IServiceProvider serviceProvider)
        {
            await SeedDepartmentAsync(context);
            await SeedRoleAsync(context, serviceProvider);
            await SeedUserAsync(context, serviceProvider);
        }

        private static async Task SeedRoleAsync(ApplicationDbContext context, IServiceProvider serviceProvider)
        {
            var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();

            foreach (var role in InitialData.Roles)
            {
                if (!await roleManager.RoleExistsAsync(role.Name))
                {
                    await roleManager.CreateAsync(role);
                }
            }
            
        }

        private static async Task SeedUserAsync(ApplicationDbContext context, IServiceProvider serviceProvider)
        {
            var userManager = serviceProvider.GetRequiredService<UserManager<User>>();

            var departments = await context.Departments.Where(e => e.Code == "CDS" || e.Code == "AI").ToListAsync();

            foreach (var user in InitialData.Users)
            {
                var existingUser = await userManager.FindByEmailAsync(user.Email);
                if (existingUser == null)
                {
                    if (user.Email.ToLower().Contains("Admin".ToLower()))
                    {
                        var department = departments.FirstOrDefault(e => e.Code == "CDS");
                        user.DepartmentId = department!.Id;
                    }
                    else
                    {
                        var department = departments.FirstOrDefault(e => e.Code == "AI");
                        user.DepartmentId = department!.Id;
                    }

                    var createUser = await userManager.CreateAsync(user, "Admin@123");
                    if (createUser.Succeeded)
                    {
                        var role = user.Email == "admin@example.com" ? "Admin" : "User";

                        await userManager.AddToRoleAsync(user, role);
                    }
                }
            }

        }

        private static async Task SeedDepartmentAsync(ApplicationDbContext context)
        {
            if (!await context.Departments.AnyAsync())
            {
                await context.Departments.AddRangeAsync(InitialData.Departments);
                await context.SaveChangesAsync();
            }
        }
    }
}
