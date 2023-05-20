﻿// <auto-generated />
using EFM_Project.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EFM_Project.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230519174744_initial3")]
    partial class initial3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EFM_Project.Models.Category", b =>
                {
                    b.Property<int>("Category_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Category_image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Category_name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Category_id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("EFM_Project.Models.Etapes", b =>
                {
                    b.Property<int>("Etape_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Etape_description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Etape_order")
                        .HasColumnType("int");

                    b.Property<string>("Etape_title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Meal_id")
                        .HasColumnType("int");

                    b.HasKey("Etape_id");

                    b.HasIndex("Meal_id");

                    b.ToTable("Etapes");
                });

            modelBuilder.Entity("EFM_Project.Models.Feedback", b =>
                {
                    b.Property<int>("Feedback_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Meal_id")
                        .HasColumnType("int");

                    b.Property<string>("feedback")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Feedback_id");

                    b.HasIndex("Meal_id");

                    b.ToTable("Feedbacks");
                });

            modelBuilder.Entity("EFM_Project.Models.Ingredient", b =>
                {
                    b.Property<int>("Ingredient_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ingredient_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Unit")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Ingredient_id");

                    b.ToTable("Ingredients");
                });

            modelBuilder.Entity("EFM_Project.Models.Meal", b =>
                {
                    b.Property<int>("Meal_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Category_id")
                        .HasColumnType("int");

                    b.Property<int>("MealCategory")
                        .HasColumnType("int");

                    b.Property<string>("Meal_description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Meal_image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Meal_name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Meal_id");

                    b.HasIndex("Category_id");

                    b.ToTable("Meals");
                });

            modelBuilder.Entity("EFM_Project.Models.Quantity", b =>
                {
                    b.Property<int>("Etape_id")
                        .HasColumnType("int");

                    b.Property<int>("Ingredient_id")
                        .HasColumnType("int");

                    b.Property<int>("Qte")
                        .HasColumnType("int");

                    b.HasKey("Etape_id", "Ingredient_id");

                    b.HasIndex("Ingredient_id");

                    b.ToTable("Quantity");
                });

            modelBuilder.Entity("EFM_Project.Models.Etapes", b =>
                {
                    b.HasOne("EFM_Project.Models.Meal", "Meal")
                        .WithMany()
                        .HasForeignKey("Meal_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Meal");
                });

            modelBuilder.Entity("EFM_Project.Models.Feedback", b =>
                {
                    b.HasOne("EFM_Project.Models.Meal", "Meal")
                        .WithMany()
                        .HasForeignKey("Meal_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Meal");
                });

            modelBuilder.Entity("EFM_Project.Models.Meal", b =>
                {
                    b.HasOne("EFM_Project.Models.Category", "Category")
                        .WithMany("Meals")
                        .HasForeignKey("Category_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("EFM_Project.Models.Quantity", b =>
                {
                    b.HasOne("EFM_Project.Models.Ingredient", "Ingredient")
                        .WithMany("Quantities")
                        .HasForeignKey("Etape_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFM_Project.Models.Etapes", "Etapes")
                        .WithMany("Quantities")
                        .HasForeignKey("Ingredient_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Etapes");

                    b.Navigation("Ingredient");
                });

            modelBuilder.Entity("EFM_Project.Models.Category", b =>
                {
                    b.Navigation("Meals");
                });

            modelBuilder.Entity("EFM_Project.Models.Etapes", b =>
                {
                    b.Navigation("Quantities");
                });

            modelBuilder.Entity("EFM_Project.Models.Ingredient", b =>
                {
                    b.Navigation("Quantities");
                });
#pragma warning restore 612, 618
        }
    }
}
