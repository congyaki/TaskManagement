﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskManagement.Entities;

namespace TaskManagement.Data.Configurations
{
    public class CommentConfiguration : IEntityTypeConfiguration<TblComment>
    {
        public void Configure(EntityTypeBuilder<TblComment> builder)
        {
            builder.HasOne(u => u.Task)
                .WithMany(d => d.Comments)
                .HasForeignKey(u => u.TaskId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(u => u.User)
                .WithMany(d => d.Comments)
                .HasForeignKey(u => u.UserId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
