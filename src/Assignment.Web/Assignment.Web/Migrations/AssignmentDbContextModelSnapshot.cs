﻿// <auto-generated />
using System;
using Assignment.Web.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Assignment.Web.Migrations
{
    [DbContext(typeof(AssignmentDbContext))]
    partial class AssignmentDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Assignment.Web.Models.BusinessEntities", b =>
                {
                    b.Property<int>("BusinessId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("Balance");

                    b.Property<string>("City")
                        .HasMaxLength(150);

                    b.Property<string>("Code")
                        .HasMaxLength(50);

                    b.Property<string>("ContactPerson");

                    b.Property<string>("Country")
                        .HasMaxLength(150);

                    b.Property<DateTime>("CreatedOnUtc");

                    b.Property<float>("CurrentBalance");

                    b.Property<bool>("Deleted");

                    b.Property<string>("Email");

                    b.Property<string>("LoginUrl")
                        .HasMaxLength(50);

                    b.Property<string>("Logo");

                    b.Property<int>("MarkupPlanId");

                    b.Property<string>("Mobile")
                        .HasMaxLength(50);

                    b.Property<string>("Name");

                    b.Property<string>("Phone")
                        .HasMaxLength(50);

                    b.Property<string>("ReferredBy")
                        .HasMaxLength(50);

                    b.Property<string>("SMTPPassword")
                        .HasMaxLength(50);

                    b.Property<int>("SMTPPort");

                    b.Property<string>("SMTPServer")
                        .HasMaxLength(50);

                    b.Property<string>("SMTPUsername")
                        .HasMaxLength(50);

                    b.Property<string>("SecurityCode")
                        .HasMaxLength(50);

                    b.Property<string>("State")
                        .HasMaxLength(150);

                    b.Property<int>("Status");

                    b.Property<string>("Street");

                    b.Property<DateTime>("UpdatedOnUtc");

                    b.Property<string>("Zip")
                        .HasMaxLength(50);

                    b.HasKey("BusinessId");

                    b.HasIndex("MarkupPlanId");

                    b.ToTable("BusinessEntities");

                    b.HasData(
                        new { BusinessId = 1, Balance = 0f, City = "Dhaka", Code = "H1213", Country = "Bangladesh", CreatedOnUtc = new DateTime(2019, 4, 5, 12, 1, 51, 678, DateTimeKind.Utc), CurrentBalance = 0f, Deleted = false, Email = "test@gmail.com", Logo = "default.png", MarkupPlanId = 1, Mobile = "01455654255", Name = "Eco Travels", SMTPPort = 0, State = "Dhaka", Status = 1, UpdatedOnUtc = new DateTime(2019, 4, 5, 12, 1, 51, 678, DateTimeKind.Utc), Zip = "1522" },
                        new { BusinessId = 2, Balance = 0f, City = "Dhaka", Code = "1213", Country = "Bangladesh", CreatedOnUtc = new DateTime(2019, 4, 5, 12, 1, 51, 678, DateTimeKind.Utc), CurrentBalance = 0f, Deleted = false, Email = "nz@gmail.com", Logo = "default.png", MarkupPlanId = 1, Mobile = "01455654255", Name = "Nazma Travels", SMTPPort = 0, State = "Dhaka", Status = 1, UpdatedOnUtc = new DateTime(2019, 4, 5, 12, 1, 51, 678, DateTimeKind.Utc), Zip = "1522" },
                        new { BusinessId = 3, Balance = 0f, City = "Dhaka", Code = "F4555", Country = "Bangladesh", CreatedOnUtc = new DateTime(2019, 4, 5, 12, 1, 51, 678, DateTimeKind.Utc), CurrentBalance = 0f, Deleted = false, Email = "desh@gmail.com", Logo = "default.png", MarkupPlanId = 1, Mobile = "01455654255", Name = "Desh Travels", SMTPPort = 0, State = "Dhaka", Status = 1, UpdatedOnUtc = new DateTime(2019, 4, 5, 12, 1, 51, 678, DateTimeKind.Utc), Zip = "1522" },
                        new { BusinessId = 4, Balance = 0f, City = "Dhaka", Code = "H1213", Country = "Bangladesh", CreatedOnUtc = new DateTime(2019, 4, 5, 12, 1, 51, 678, DateTimeKind.Utc), CurrentBalance = 0f, Deleted = false, Email = "test@gmail.com", Logo = "default.png", MarkupPlanId = 2, Mobile = "01455654255", Name = "Alone Travels", SMTPPort = 0, State = "Dhaka", Status = 1, UpdatedOnUtc = new DateTime(2019, 4, 5, 12, 1, 51, 678, DateTimeKind.Utc), Zip = "1522" },
                        new { BusinessId = 5, Balance = 0f, City = "Dhaka", Code = "G343422", Country = "Bangladesh", CreatedOnUtc = new DateTime(2019, 4, 5, 12, 1, 51, 678, DateTimeKind.Utc), CurrentBalance = 0f, Deleted = false, Email = "test@gmail.com", Logo = "default.png", MarkupPlanId = 1, Mobile = "01455654255", Name = "Undefined Travels", SMTPPort = 0, State = "Dhaka", Status = 1, UpdatedOnUtc = new DateTime(2019, 4, 5, 12, 1, 51, 678, DateTimeKind.Utc), Zip = "1522" },
                        new { BusinessId = 6, Balance = 0f, City = "Dhaka", Code = "23552", Country = "Bangladesh", CreatedOnUtc = new DateTime(2019, 4, 5, 12, 1, 51, 678, DateTimeKind.Utc), CurrentBalance = 0f, Deleted = false, Email = "test@gmail.com", Logo = "default.png", MarkupPlanId = 3, Mobile = "01455654255", Name = "No Name Travels", SMTPPort = 0, State = "Dhaka", Status = 1, UpdatedOnUtc = new DateTime(2019, 4, 5, 12, 1, 51, 678, DateTimeKind.Utc), Zip = "1522" }
                    );
                });

            modelBuilder.Entity("Assignment.Web.Models.MarkupPlan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("MarkupPlan");

                    b.HasData(
                        new { Id = 1, Name = "HT Agent and Transaction Above 15 Lac" },
                        new { Id = 2, Name = "HT Agent and Transaction Above 35 Lac" },
                        new { Id = 3, Name = "HT Agent and Transaction Above 45 Lac" }
                    );
                });

            modelBuilder.Entity("Assignment.Web.Models.BusinessEntities", b =>
                {
                    b.HasOne("Assignment.Web.Models.MarkupPlan", "MarkupPlan")
                        .WithMany("BusinessEntities")
                        .HasForeignKey("MarkupPlanId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
