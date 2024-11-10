﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TaskManagement.Data;

#nullable disable

namespace TaskManagement.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241110103004_UpdateTblTask")]
    partial class UpdateTblTask
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.35")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("RoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("UserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("UserTokens", (string)null);
                });

            modelBuilder.Entity("TaskManagement.Entities.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("Roles", (string)null);
                });

            modelBuilder.Entity("TaskManagement.Entities.TaskFile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("CREATED_AT");

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int")
                        .HasColumnName("CREATED_BY");

                    b.Property<string>("FilePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("FILE_PATH");

                    b.Property<DateTime?>("LastModifiedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("LAST_MODIFIED_AT");

                    b.Property<int?>("LastModifiedBy")
                        .HasColumnType("int")
                        .HasColumnName("LAST_MODIFIED_BY");

                    b.Property<int>("TaskId")
                        .HasColumnType("int")
                        .HasColumnName("TASK_ID");

                    b.HasKey("Id");

                    b.HasIndex("TaskId");

                    b.ToTable("TBL_TASK_FILES");
                });

            modelBuilder.Entity("TaskManagement.Entities.TaskLabel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("CREATED_AT");

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int")
                        .HasColumnName("CREATED_BY");

                    b.Property<int>("LabelId")
                        .HasColumnType("int")
                        .HasColumnName("LABEL_ID");

                    b.Property<DateTime?>("LastModifiedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("LAST_MODIFIED_AT");

                    b.Property<int?>("LastModifiedBy")
                        .HasColumnType("int")
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

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("CREATED_AT");

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int")
                        .HasColumnName("CREATED_BY");

                    b.Property<DateTime?>("LastModifiedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("LAST_MODIFIED_AT");

                    b.Property<int?>("LastModifiedBy")
                        .HasColumnType("int")
                        .HasColumnName("LAST_MODIFIED_BY");

                    b.Property<int>("TaskId")
                        .HasColumnType("int")
                        .HasColumnName("TASK_ID");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("USER_ID");

                    b.HasKey("Id");

                    b.HasIndex("TaskId");

                    b.HasIndex("UserId");

                    b.ToTable("TBL_TASK_USERS");
                });

            modelBuilder.Entity("TaskManagement.Entities.TblComment", b =>
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

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("CREATED_AT");

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int")
                        .HasColumnName("CREATED_BY");

                    b.Property<DateTime?>("LastModifiedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("LAST_MODIFIED_AT");

                    b.Property<int?>("LastModifiedBy")
                        .HasColumnType("int")
                        .HasColumnName("LAST_MODIFIED_BY");

                    b.Property<int>("TaskId")
                        .HasColumnType("int")
                        .HasColumnName("TASK_ID");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("USER_ID");

                    b.HasKey("Id");

                    b.HasIndex("TaskId");

                    b.HasIndex("UserId");

                    b.ToTable("TBL_COMMENTS");
                });

            modelBuilder.Entity("TaskManagement.Entities.TblDmDepartment", b =>
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

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("CREATED_AT");

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int")
                        .HasColumnName("CREATED_BY");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("DESCRIPTION");

                    b.Property<DateTime?>("LastModifiedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("LAST_MODIFIED_AT");

                    b.Property<int?>("LastModifiedBy")
                        .HasColumnType("int")
                        .HasColumnName("LAST_MODIFIED_BY");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("NAME");

                    b.HasKey("Id");

                    b.ToTable("TBL_DM_DEPARTMENTS");
                });

            modelBuilder.Entity("TaskManagement.Entities.TblDmLabel", b =>
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

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("CREATED_AT");

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int")
                        .HasColumnName("CREATED_BY");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("DESCRIPTION");

                    b.Property<DateTime?>("LastModifiedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("LAST_MODIFIED_AT");

                    b.Property<int?>("LastModifiedBy")
                        .HasColumnType("int")
                        .HasColumnName("LAST_MODIFIED_BY");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("NAME");

                    b.HasKey("Id");

                    b.ToTable("TBL_DM_LABELS");
                });

            modelBuilder.Entity("TaskManagement.Entities.TblFailedJob", b =>
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

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("CREATED_AT");

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int")
                        .HasColumnName("CREATED_BY");

                    b.Property<string>("Exception")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("EXCEPTION");

                    b.Property<DateTime>("FailedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("FAILED_AT");

                    b.Property<DateTime?>("LastModifiedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("LAST_MODIFIED_AT");

                    b.Property<int?>("LastModifiedBy")
                        .HasColumnType("int")
                        .HasColumnName("LAST_MODIFIED_BY");

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

            modelBuilder.Entity("TaskManagement.Entities.TblJob", b =>
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

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("CREATED_AT");

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int")
                        .HasColumnName("CREATED_BY");

                    b.Property<DateTime?>("LastModifiedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("LAST_MODIFIED_AT");

                    b.Property<int?>("LastModifiedBy")
                        .HasColumnType("int")
                        .HasColumnName("LAST_MODIFIED_BY");

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

            modelBuilder.Entity("TaskManagement.Entities.TblTask", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("CREATED_AT");

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int")
                        .HasColumnName("CREATED_BY");

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

                    b.Property<int?>("LastModifiedBy")
                        .HasColumnType("int")
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

                    b.ToTable("TBL_TASKS");
                });

            modelBuilder.Entity("TaskManagement.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("Users", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("TaskManagement.Entities.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("TaskManagement.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("TaskManagement.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("TaskManagement.Entities.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TaskManagement.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("TaskManagement.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TaskManagement.Entities.TaskFile", b =>
                {
                    b.HasOne("TaskManagement.Entities.TblTask", "Task")
                        .WithMany("TaskFiles")
                        .HasForeignKey("TaskId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Task");
                });

            modelBuilder.Entity("TaskManagement.Entities.TaskLabel", b =>
                {
                    b.HasOne("TaskManagement.Entities.TblDmLabel", "Label")
                        .WithMany("TaskLabels")
                        .HasForeignKey("LabelId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("TaskManagement.Entities.TblTask", "Task")
                        .WithMany("TaskLabels")
                        .HasForeignKey("TaskId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Label");

                    b.Navigation("Task");
                });

            modelBuilder.Entity("TaskManagement.Entities.TaskUser", b =>
                {
                    b.HasOne("TaskManagement.Entities.TblTask", "Task")
                        .WithMany("TaskUsers")
                        .HasForeignKey("TaskId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("TaskManagement.Entities.User", "User")
                        .WithMany("TaskUsers")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Task");

                    b.Navigation("User");
                });

            modelBuilder.Entity("TaskManagement.Entities.TblComment", b =>
                {
                    b.HasOne("TaskManagement.Entities.TblTask", "Task")
                        .WithMany("Comments")
                        .HasForeignKey("TaskId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("TaskManagement.Entities.User", "User")
                        .WithMany("Comments")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Task");

                    b.Navigation("User");
                });

            modelBuilder.Entity("TaskManagement.Entities.User", b =>
                {
                    b.HasOne("TaskManagement.Entities.TblDmDepartment", "Department")
                        .WithMany("Users")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("TaskManagement.Entities.TblDmDepartment", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("TaskManagement.Entities.TblDmLabel", b =>
                {
                    b.Navigation("TaskLabels");
                });

            modelBuilder.Entity("TaskManagement.Entities.TblTask", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("TaskFiles");

                    b.Navigation("TaskLabels");

                    b.Navigation("TaskUsers");
                });

            modelBuilder.Entity("TaskManagement.Entities.User", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("TaskUsers");
                });
#pragma warning restore 612, 618
        }
    }
}
