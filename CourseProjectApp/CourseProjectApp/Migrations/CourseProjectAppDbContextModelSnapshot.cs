using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using CourseProjectApp.EntityModels;

namespace CourseProjectApp.Migrations
{
    [DbContext(typeof(CourseProjectAppDbContext))]
    partial class CourseProjectAppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CourseProjectApp.EntityModels.Login", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Password");

                    b.Property<string>("Username");

                    b.HasKey("ID");

                    b.ToTable("Login");
                });

            modelBuilder.Entity("CourseProjectApp.EntityModels.Register", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Password");

                    b.Property<string>("Username");

                    b.HasKey("ID");

                    b.ToTable("Register");
                });
        }
    }
}
