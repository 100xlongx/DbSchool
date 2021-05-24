﻿// <auto-generated />
using App;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace App.Migrations
{
    [DbContext(typeof(SchoolContext))]
    [Migration("20210524185446_MoreInfointoDB")]
    partial class MoreInfointoDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.6");

            modelBuilder.Entity("App.Grade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CourseName")
                        .HasColumnType("TEXT");

                    b.Property<float>("GradeP")
                        .HasColumnType("REAL");

                    b.Property<int>("StudentId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("StudentId");

                    b.ToTable("Grades");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CourseName = "Spanish",
                            GradeP = 0.2f,
                            StudentId = 1
                        },
                        new
                        {
                            Id = 2,
                            CourseName = "Geometry",
                            GradeP = 0.9f,
                            StudentId = 2
                        },
                        new
                        {
                            Id = 3,
                            CourseName = "Mathematics",
                            GradeP = 0.25f,
                            StudentId = 3
                        },
                        new
                        {
                            Id = 4,
                            CourseName = "Mathematics",
                            GradeP = 0.75f,
                            StudentId = 1
                        },
                        new
                        {
                            Id = 5,
                            CourseName = "Mathematics",
                            GradeP = 0.85f,
                            StudentId = 2
                        },
                        new
                        {
                            Id = 6,
                            CourseName = "Geometry",
                            GradeP = 0.75f,
                            StudentId = 3
                        });
                });

            modelBuilder.Entity("App.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Age")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<int>("classification")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 0,
                            FirstName = "Pickle",
                            LastName = "Rick",
                            classification = 0
                        },
                        new
                        {
                            Id = 2,
                            Age = 0,
                            FirstName = "Rick",
                            LastName = "Sanchez",
                            classification = 0
                        },
                        new
                        {
                            Id = 3,
                            Age = 0,
                            FirstName = "Tom",
                            LastName = "Hanks",
                            classification = 0
                        },
                        new
                        {
                            Id = 4,
                            Age = 0,
                            FirstName = "Sussy",
                            LastName = "Backa",
                            classification = 0
                        });
                });

            modelBuilder.Entity("App.Grade", b =>
                {
                    b.HasOne("App.Student", null)
                        .WithMany("grades")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("App.Student", b =>
                {
                    b.Navigation("grades");
                });
#pragma warning restore 612, 618
        }
    }
}
