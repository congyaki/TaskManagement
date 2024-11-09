using Microsoft.AspNetCore.Identity;
using System.Net;
using TaskManagement.Entities;

namespace TaskManagement.Data.Extensions
{
    internal class InitialData
    {
        public static IEnumerable<User> Users => new List<User>()
        {
            new() {
                UserName = "admin@example.com",
                Email = "admin@example.com",
                EmailConfirmed = true,
                DepartmentId = 1,
            },
            new() {
                UserName = "user@example.com",
                Email = "user@example.com",
                EmailConfirmed = true,
                DepartmentId = 2,
            }

        };

        public static IEnumerable<Role> Roles => new List<Role>()
        {
            new("Admin"),
            new("User")

        };

        public static IEnumerable<TblDmDepartment> Departments => new List<TblDmDepartment>()
        {
            new() {
                Code = "CDS",
                Name = "Chuyển đổi số",
                CreatedAt = DateTime.Now,
                CreatedBy = "Seed Data",
                LastModifiedAt = DateTime.Now,
                LastModifiedBy = "Seed Data"
            },
            new() {
                Code = "AI",
                Name = "Trí tuệ nhân tạo",
                CreatedAt = DateTime.Now,
                CreatedBy = "Seed Data",
                LastModifiedAt = DateTime.Now,
                LastModifiedBy = "Seed Data"
            },

        };

        public static IEnumerable<TblDmLabel> Labels => new List<TblDmLabel>()
        {
            new() {
                Code = "CTDT",
                Name = "Chương trình đào tạo",
                CreatedAt = DateTime.Now,
                CreatedBy = "Seed Data",
                LastModifiedAt = DateTime.Now,
                LastModifiedBy = "Seed Data"
            },
            new() {
                Code = "HOC_TAP",
                Name = "Học tập",
                CreatedAt = DateTime.Now,
                CreatedBy = "Seed Data",
                LastModifiedAt = DateTime.Now,
                LastModifiedBy = "Seed Data"
            },

        };

    }
}
