﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication1.Data;

#nullable disable

namespace WebApplication1.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    [Migration("20240309153000_UpdateAuthorMemoryRelation2")]
    partial class UpdateAuthorMemoryRelation2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebApplication1.Models.Author", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Name = "John Doe"
                        },
                        new
                        {
                            ID = 2,
                            Name = "Jane Doe"
                        });
                });

            modelBuilder.Entity("WebApplication1.Models.Memory", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int?>("AuthorID")
                        .HasColumnType("int");

                    b.Property<DateOnly>("Date")
                        .HasColumnType("date");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("AuthorID");

                    b.ToTable("Memories");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            AuthorID = 1,
                            Date = new DateOnly(2023, 3, 9),
                            Description = "First Memory"
                        },
                        new
                        {
                            ID = 2,
                            AuthorID = 2,
                            Date = new DateOnly(2023, 3, 9),
                            Description = "Second Memory"
                        });
                });

            modelBuilder.Entity("WebApplication1.Models.Memory", b =>
                {
                    b.HasOne("WebApplication1.Models.Author", "Author")
                        .WithMany("Memories")
                        .HasForeignKey("AuthorID");

                    b.Navigation("Author");
                });

            modelBuilder.Entity("WebApplication1.Models.Author", b =>
                {
                    b.Navigation("Memories");
                });
#pragma warning restore 612, 618
        }
    }
}
