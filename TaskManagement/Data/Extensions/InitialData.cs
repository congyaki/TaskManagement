using Microsoft.AspNetCore.Identity;
using System.Net;
using TaskManagement.Entities;
using TaskManagement.enums;
using TaskStatus = TaskManagement.enums.TaskStatus;

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
                Description = "Môn chuyển đổi số",
                CreatedAt = DateTime.Now,
                CreatedBy = 0,
                LastModifiedAt = DateTime.Now,
                LastModifiedBy = 0
            },
            new() {
                Code = "AI",
                Name = "Trí tuệ nhân tạo",
                Description = "Môn trí tuệ nhân tạo",
                CreatedAt = DateTime.Now,
                CreatedBy = 0,
                LastModifiedAt = DateTime.Now,
                LastModifiedBy = 0
            },

        };

        public static IEnumerable<TblDmLabel> Labels => new List<TblDmLabel>()
        {
            new() {
                Code = "CTDT",
                Name = "Chương trình đào tạo",
                Color = "#0000",
                Description = "Chương trình đào tạo",
                CreatedAt = DateTime.Now,
                CreatedBy = 0,
                LastModifiedAt = DateTime.Now,
                LastModifiedBy = 0
            },
            new() {
                Code = "HOC_TAP",
                Name = "Học tập",
                Color = "#ffff",
                Description = "Học tập",
                CreatedAt = DateTime.Now,
                CreatedBy = 0,
                LastModifiedAt = DateTime.Now,
                LastModifiedBy = 0
            },

        };

        public static IEnumerable<TblTask> Tasks => new List<TblTask>()
        {
            new() {
                Title = "Complete project documentation",
                Description = "Prepare and complete all project documentation.",
                CreatedAt = DateTime.Now,
                CreatedBy = 0,
                Status = TaskStatus.Pending,
            },
            new() {
                Title = "Develop authentication module",
                Description = "Implement user authentication and authorization.",
                CreatedAt = DateTime.Now,
                CreatedBy = 0,
                Status = TaskStatus.Pending,
            }
        };

    }
}
