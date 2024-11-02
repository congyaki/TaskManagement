using Microsoft.AspNetCore.Identity;
using System.Net;
using TaskManagement.Entities;

namespace TaskManagement.Data.Extensions
{
    internal class InitialData
    {
        public static IEnumerable<User> Users => new List<User>()
        {
            new User
            {
                UserName = "admin@example.com",
                Email = "admin@example.com",
                EmailConfirmed = true,
                DepartmentId = 1,
            },
            new User
            {
                UserName = "user@example.com",
                Email = "user@example.com",
                EmailConfirmed = true,
                DepartmentId = 2,
            }

        };

        public static IEnumerable<IdentityRole> Roles => new List<IdentityRole>()
        {
            new IdentityRole("Admin"),
            new IdentityRole("User")

        };

        public static IEnumerable<Department> Departments => new List<Department>()
        {
            new Department
            {
                Code = "CDS",
                Name = "Chuyển đổi số",
                CreatedAt = DateTime.Now,
                CreatedBy = "Seed Data",
                LastModifiedAt = DateTime.Now,
                LastModifiedBy = "Seed Data"
            },
            new Department
            {
                Code = "AI",
                Name = "Trí tuệ nhân tạo",
                CreatedAt = DateTime.Now,
                CreatedBy = "Seed Data",
                LastModifiedAt = DateTime.Now,
                LastModifiedBy = "Seed Data"
            },

        };

    }
}
