﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TaskManagement.Data;

#nullable disable

namespace TaskManagement.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241027154912_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.35")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("TaskManagement.Entities.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("CONTENT");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("CREATED_AT");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("CREATED_BY");

                    b.Property<DateTime?>("LastModifiedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("LAST_MODIFIED_AT");

                    b.Property<string>("LastModifiedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("LAST_MODIFIED_BY");

                    b.Property<int>("TaskId")
                        .HasColumnType("int")
                        .HasColumnName("TASK_ID");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("USER_ID");

                    b.HasKey("Id");

                    b.HasIndex("TaskId");

                    b.ToTable("TBL_COMMENTS");
                });

            modelBuilder.Entity("TaskManagement.Entities.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("CODE");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("CREATED_AT");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("CREATED_BY");

                    b.Property<DateTime?>("LastModifiedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("LAST_MODIFIED_AT");

                    b.Property<string>("LastModifiedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("LAST_MODIFIED_BY");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("NAME");

                    b.HasKey("Id");

                    b.ToTable("TBL_DM_DEPARTMENTS");
                });

            modelBuilder.Entity("TaskManagement.Entities.FailedJob", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Connection")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("CONNECTION");

                    b.Property<string>("Exception")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("EXCEPTION");

                    b.Property<DateTime>("FailedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("FAILED_AT");

                    b.Property<string>("Payload")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("PAYLOAD");

                    b.Property<string>("Queue")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("QUEUE");

                    b.Property<Guid>("Uuid")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("UUID");

                    b.HasKey("Id");

                    b.ToTable("TBL_FAILED_JOBS");
                });

            modelBuilder.Entity("TaskManagement.Entities.Job", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Attempts")
                        .HasColumnType("int")
                        .HasColumnName("ATTEMPTS");

                    b.Property<DateTime?>("AvailableAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("AVAILABLE_AT");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("CREATED_AT");

                    b.Property<string>("Payload")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("PAYLOAD");

                    b.Property<string>("Queue")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("QUEUE");

                    b.Property<DateTime?>("ReservedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("RESERVED_AT");

                    b.HasKey("Id");

                    b.ToTable("TBL_JOBS");
                });

            modelBuilder.Entity("TaskManagement.Entities.Label", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("CODE");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("COLOR");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("CREATED_AT");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("CREATED_BY");

                    b.Property<DateTime?>("LastModifiedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("LAST_MODIFIED_AT");

                    b.Property<string>("LastModifiedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("LAST_MODIFIED_BY");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("NAME");

                    b.HasKey("Id");

                    b.ToTable("TBL_DM_LABELS");
                });

            modelBuilder.Entity("TaskManagement.Entities.Task", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("CREATED_AT");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("CREATED_BY");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int")
                        .HasColumnName("DEPARTMENT_ID");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("DESCRIPTION");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("END_DATE");

                    b.Property<double?>("EstimatedTime")
                        .HasColumnType("float")
                        .HasColumnName("ESTIMATED_TIME");

                    b.Property<DateTime?>("LastModifiedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("LAST_MODIFIED_AT");

                    b.Property<string>("LastModifiedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("LAST_MODIFIED_BY");

                    b.Property<int?>("ParentId")
                        .HasColumnType("int")
                        .HasColumnName("PARENT_ID");

                    b.Property<int?>("Priority")
                        .HasColumnType("int")
                        .HasColumnName("PRIORITY");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("START_DATE");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("STATUS");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("TITLE");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("ParentId");

                    b.ToTable("TBL_TASKS");
                });

            modelBuilder.Entity("TaskManagement.Entities.TaskLabel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("CREATED_AT");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("CREATED_BY");

                    b.Property<int>("LabelId")
                        .HasColumnType("int")
                        .HasColumnName("LABEL_ID");

                    b.Property<DateTime?>("LastModifiedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("LAST_MODIFIED_AT");

                    b.Property<string>("LastModifiedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("LAST_MODIFIED_BY");

                    b.Property<int>("TaskId")
                        .HasColumnType("int")
                        .HasColumnName("TASK_ID");

                    b.HasKey("Id");

                    b.HasIndex("LabelId");

                    b.HasIndex("TaskId");

                    b.ToTable("TBL_TASK_LABELS");
                });

            modelBuilder.Entity("TaskManagement.Entities.TaskUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("CREATED_AT");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("CREATED_BY");

                    b.Property<DateTime?>("LastModifiedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("LAST_MODIFIED_AT");

                    b.Property<string>("LastModifiedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("LAST_MODIFIED_BY");

                    b.Property<int>("TaskId")
                        .HasColumnType("int")
                        .HasColumnName("TASK_ID");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("USER_ID");

                    b.HasKey("Id");

                    b.HasIndex("TaskId");

                    b.ToTable("TBL_TASK_USERS");
                });

            modelBuilder.Entity("TaskManagement.Entities.Comment", b =>
                {
                    b.HasOne("TaskManagement.Entities.Task", null)
                        .WithMany()
                        .HasForeignKey("TaskId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TaskManagement.Entities.Task", b =>
                {
                    b.HasOne("TaskManagement.Entities.Department", null)
                        .WithMany()
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TaskManagement.Entities.Task", null)
                        .WithMany()
                        .HasForeignKey("ParentId");
                });

            modelBuilder.Entity("TaskManagement.Entities.TaskLabel", b =>
                {
                    b.HasOne("TaskManagement.Entities.Label", null)
                        .WithMany()
                        .HasForeignKey("LabelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TaskManagement.Entities.Task", null)
                        .WithMany()
                        .HasForeignKey("TaskId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TaskManagement.Entities.TaskUser", b =>
                {
                    b.HasOne("TaskManagement.Entities.Task", null)
                        .WithMany()
                        .HasForeignKey("TaskId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}