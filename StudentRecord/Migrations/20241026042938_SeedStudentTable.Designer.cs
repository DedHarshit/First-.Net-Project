﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StudentRecord.Data;

#nullable disable

namespace StudentRecord.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241026042938_SeedStudentTable")]
    partial class SeedStudentTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("StudentRecord.Models.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentId"));

                    b.Property<int>("StudentClass")
                        .HasColumnType("int");

                    b.Property<string>("StudentName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudentId");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            StudentId = 1,
                            StudentClass = 12,
                            StudentName = "Harshit"
                        },
                        new
                        {
                            StudentId = 2,
                            StudentClass = 11,
                            StudentName = "HEHE"
                        },
                        new
                        {
                            StudentId = 3,
                            StudentClass = 10,
                            StudentName = "PEPE"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
