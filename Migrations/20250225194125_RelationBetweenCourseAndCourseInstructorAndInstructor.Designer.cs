﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Program.DbContexts;

#nullable disable

namespace Program.Migrations
{
    [DbContext(typeof(ITIDbContext))]
    [Migration("20250225194125_RelationBetweenCourseAndCourseInstructorAndInstructor")]
    partial class RelationBetweenCourseAndCourseInstructorAndInstructor
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Program.Modules.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("TopId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TopId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("Program.Modules.CourseInstructor", b =>
                {
                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int>("InstId")
                        .HasColumnType("int");

                    b.Property<string>("Evaluation")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("CourseId", "InstId");

                    b.HasIndex("InstId");

                    b.ToTable("CourseInstructor");
                });

            modelBuilder.Entity("Program.Modules.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("HiringDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<int>("InsId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.HasIndex("InsId")
                        .IsUnique();

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("Program.Modules.Instructor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float?>("Bonus")
                        .HasColumnType("real");

                    b.Property<int>("DeptID")
                        .HasColumnType("int");

                    b.Property<float>("HourRate")
                        .HasColumnType("real");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<float>("Salary")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("DeptID");

                    b.ToTable("Instructors");
                });

            modelBuilder.Entity("Program.Modules.StudCourse", b =>
                {
                    b.Property<int>("StudId")
                        .HasColumnType("int");

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<float?>("Grade")
                        .HasColumnType("real");

                    b.HasKey("StudId", "CourseId");

                    b.HasIndex("CourseId");

                    b.ToTable("StudCourse");
                });

            modelBuilder.Entity("Program.Modules.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int>("DeptId")
                        .HasColumnType("int");

                    b.Property<string>("FName")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("LName")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.HasIndex("DeptId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("Program.Modules.Topic", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Topics");
                });

            modelBuilder.Entity("Program.Modules.Course", b =>
                {
                    b.HasOne("Program.Modules.Topic", "Topic")
                        .WithMany("Courses")
                        .HasForeignKey("TopId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Topic");
                });

            modelBuilder.Entity("Program.Modules.CourseInstructor", b =>
                {
                    b.HasOne("Program.Modules.Course", "Course")
                        .WithMany("CourseInstructor")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Program.Modules.Instructor", "Instructor")
                        .WithMany("CourseInstructor")
                        .HasForeignKey("InstId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Instructor");
                });

            modelBuilder.Entity("Program.Modules.Department", b =>
                {
                    b.HasOne("Program.Modules.Instructor", "Manager")
                        .WithOne("ManagedDepartment")
                        .HasForeignKey("Program.Modules.Department", "InsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Manager");
                });

            modelBuilder.Entity("Program.Modules.Instructor", b =>
                {
                    b.HasOne("Program.Modules.Department", "Department")
                        .WithMany("Instructors")
                        .HasForeignKey("DeptID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("Program.Modules.StudCourse", b =>
                {
                    b.HasOne("Program.Modules.Course", "Course")
                        .WithMany("StudCourse")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Program.Modules.Student", "Student")
                        .WithMany("StudCourse")
                        .HasForeignKey("StudId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Program.Modules.Student", b =>
                {
                    b.HasOne("Program.Modules.Department", "Department")
                        .WithMany("Students")
                        .HasForeignKey("DeptId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("Program.Modules.Course", b =>
                {
                    b.Navigation("CourseInstructor");

                    b.Navigation("StudCourse");
                });

            modelBuilder.Entity("Program.Modules.Department", b =>
                {
                    b.Navigation("Instructors");

                    b.Navigation("Students");
                });

            modelBuilder.Entity("Program.Modules.Instructor", b =>
                {
                    b.Navigation("CourseInstructor");

                    b.Navigation("ManagedDepartment");
                });

            modelBuilder.Entity("Program.Modules.Student", b =>
                {
                    b.Navigation("StudCourse");
                });

            modelBuilder.Entity("Program.Modules.Topic", b =>
                {
                    b.Navigation("Courses");
                });
#pragma warning restore 612, 618
        }
    }
}
