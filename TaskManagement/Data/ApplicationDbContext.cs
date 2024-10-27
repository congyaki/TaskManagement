﻿using Microsoft.EntityFrameworkCore;
using System.Reflection;
using TaskManagement.Entities;

namespace TaskManagement.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<FailedJob> FailedJobs { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Label> Labels { get; set; }
        public DbSet<Entities.Task> Tasks { get; set; }
        public DbSet<TaskLabel> TaskLabels { get; set; }
        public DbSet<TaskUser> TaskUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(builder);
        }
    }
}
