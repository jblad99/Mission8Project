﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mission8_Project.Models;

namespace Mission8_Project.Migrations
{
    [DbContext(typeof(TaskContext))]
    [Migration("20230222215221_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22");

            modelBuilder.Entity("Mission8_Project.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Categories")
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            Categories = "Home"
                        },
                        new
                        {
                            CategoryId = 2,
                            Categories = "School"
                        },
                        new
                        {
                            CategoryId = 3,
                            Categories = "Work"
                        },
                        new
                        {
                            CategoryId = 4,
                            Categories = "Church"
                        });
                });

            modelBuilder.Entity("Mission8_Project.Models.Quadrant", b =>
                {
                    b.Property<int>("QuadrantId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Quadrants")
                        .HasColumnType("TEXT");

                    b.HasKey("QuadrantId");

                    b.ToTable("Quadrants");

                    b.HasData(
                        new
                        {
                            QuadrantId = 1,
                            Quadrants = "Quadrant 1"
                        },
                        new
                        {
                            QuadrantId = 2,
                            Quadrants = "Quadrant 2"
                        },
                        new
                        {
                            QuadrantId = 3,
                            Quadrants = "Quadrant 3"
                        },
                        new
                        {
                            QuadrantId = 4,
                            Quadrants = "Quadrant 4"
                        });
                });

            modelBuilder.Entity("Mission8_Project.Models.TaskForm", b =>
                {
                    b.Property<int>("TaskId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Completed")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DueDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("QuadrantId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Task")
                        .HasColumnType("TEXT");

                    b.HasKey("TaskId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("QuadrantId");

                    b.ToTable("Responses");
                });

            modelBuilder.Entity("Mission8_Project.Models.TaskForm", b =>
                {
                    b.HasOne("Mission8_Project.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Mission8_Project.Models.Quadrant", "Quadrant")
                        .WithMany()
                        .HasForeignKey("QuadrantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}