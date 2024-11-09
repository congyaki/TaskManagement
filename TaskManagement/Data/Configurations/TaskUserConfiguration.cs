﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskManagement.Entities;

namespace TaskManagement.Data.Configurations
{
    public class TaskUserConfiguration : IEntityTypeConfiguration<TaskUser>
    {
        public void Configure(EntityTypeBuilder<TaskUser> builder)
        {
            builder.HasOne<User>()
                .WithMany()
                .HasForeignKey(t => t.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne<Entities.TblTask>()
            .WithMany()
            .HasForeignKey(t => t.TaskId);
        }
    }
}
