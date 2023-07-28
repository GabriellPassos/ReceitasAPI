﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ReceitasAPI.Data;

#nullable disable

namespace ReceitasAPI.Migrations
{
    [DbContext(typeof(RecipeContext))]
    partial class RecipeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ReceitasAPI.Models.FilterTag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("FilterTags");
                });

            modelBuilder.Entity("ReceitasAPI.Models.Ingredient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Ingredients");
                });

            modelBuilder.Entity("ReceitasAPI.Models.Ingredient_UnitMesure", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("IngredientId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("RecipeId")
                        .HasColumnType("int");

                    b.Property<int>("UnitMesureId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IngredientId");

                    b.HasIndex("RecipeId");

                    b.HasIndex("UnitMesureId");

                    b.ToTable("Ingredients_UnitsMesure");
                });

            modelBuilder.Entity("ReceitasAPI.Models.Picture", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Base64Image")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("RecipeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RecipeId");

                    b.ToTable("Pictures");
                });

            modelBuilder.Entity("ReceitasAPI.Models.Recipe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Portions")
                        .HasColumnType("int");

                    b.Property<string>("StepByStep")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Timer")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Recipes");
                });

            modelBuilder.Entity("ReceitasAPI.Models.Recipe_FilterTag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("FilterTagId")
                        .HasColumnType("int");

                    b.Property<int>("RecipeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FilterTagId");

                    b.HasIndex("RecipeId");

                    b.ToTable("Recipe_FilterTags");
                });

            modelBuilder.Entity("ReceitasAPI.Models.UnitMesure", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("UnitsMesure");
                });

            modelBuilder.Entity("ReceitasAPI.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("longblob");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("longblob");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ReceitasAPI.Models.Ingredient_UnitMesure", b =>
                {
                    b.HasOne("ReceitasAPI.Models.Ingredient", "Ingredient")
                        .WithMany("Ingredient_UnitMesure")
                        .HasForeignKey("IngredientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ReceitasAPI.Models.Recipe", "Recipe")
                        .WithMany("Ingredients")
                        .HasForeignKey("RecipeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ReceitasAPI.Models.UnitMesure", "UnitMesure")
                        .WithMany()
                        .HasForeignKey("UnitMesureId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ingredient");

                    b.Navigation("Recipe");

                    b.Navigation("UnitMesure");
                });

            modelBuilder.Entity("ReceitasAPI.Models.Picture", b =>
                {
                    b.HasOne("ReceitasAPI.Models.Recipe", "Recipe")
                        .WithMany("Pictures")
                        .HasForeignKey("RecipeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Recipe");
                });

            modelBuilder.Entity("ReceitasAPI.Models.Recipe", b =>
                {
                    b.HasOne("ReceitasAPI.Models.User", "User")
                        .WithMany("Recipes")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("ReceitasAPI.Models.Recipe_FilterTag", b =>
                {
                    b.HasOne("ReceitasAPI.Models.FilterTag", "FilterTag")
                        .WithMany("Recipe_FilterTags")
                        .HasForeignKey("FilterTagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ReceitasAPI.Models.Recipe", "Recipe")
                        .WithMany("Recipe_FilterTags")
                        .HasForeignKey("RecipeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FilterTag");

                    b.Navigation("Recipe");
                });

            modelBuilder.Entity("ReceitasAPI.Models.FilterTag", b =>
                {
                    b.Navigation("Recipe_FilterTags");
                });

            modelBuilder.Entity("ReceitasAPI.Models.Ingredient", b =>
                {
                    b.Navigation("Ingredient_UnitMesure");
                });

            modelBuilder.Entity("ReceitasAPI.Models.Recipe", b =>
                {
                    b.Navigation("Ingredients");

                    b.Navigation("Pictures");

                    b.Navigation("Recipe_FilterTags");
                });

            modelBuilder.Entity("ReceitasAPI.Models.User", b =>
                {
                    b.Navigation("Recipes");
                });
#pragma warning restore 612, 618
        }
    }
}
