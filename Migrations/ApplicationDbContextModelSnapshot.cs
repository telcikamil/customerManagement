﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using customerManagement.AppDbContext;

#nullable disable

namespace customerManagement.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CompanyCustomer", b =>
                {
                    b.Property<Guid>("CustomersId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("companiesId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("CustomersId", "companiesId");

                    b.HasIndex("companiesId");

                    b.ToTable("CompanyCustomer");
                });

            modelBuilder.Entity("customerManagement.Entities.Concrete.Company", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsMernisRequired")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Companies");

                    b.HasData(
                        new
                        {
                            Id = new Guid("f66306c4-e9a0-4261-87e0-deb0d5ebfbf6"),
                            CreatedDate = new DateTime(2023, 6, 15, 0, 12, 15, 296, DateTimeKind.Local).AddTicks(6098),
                            IsMernisRequired = true,
                            Name = "Starbucks"
                        },
                        new
                        {
                            Id = new Guid("e0685f1b-2142-46fd-88cf-7b949142a84e"),
                            CreatedDate = new DateTime(2023, 6, 15, 0, 12, 15, 296, DateTimeKind.Local).AddTicks(6143),
                            IsMernisRequired = false,
                            Name = "Portal Kahve"
                        });
                });

            modelBuilder.Entity("customerManagement.Entities.Concrete.Customer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("BirtDay")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("identityNumber")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("CompanyCustomer", b =>
                {
                    b.HasOne("customerManagement.Entities.Concrete.Customer", null)
                        .WithMany()
                        .HasForeignKey("CustomersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("customerManagement.Entities.Concrete.Company", null)
                        .WithMany()
                        .HasForeignKey("companiesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
