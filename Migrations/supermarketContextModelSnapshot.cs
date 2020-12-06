﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Project.Model;

namespace Project.Migrations
{
    [DbContext(typeof(supermarketContext))]
    partial class supermarketContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Project.Model.Customer", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("User_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("contact_NO")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("status")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("Customers");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Customer");
                });

            modelBuilder.Entity("Project.Model.Order", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<float>("Tax")
                        .HasColumnType("real");

                    b.Property<int?>("ord_cusid")
                        .HasColumnType("int");

                    b.Property<int>("status")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("ord_cusid");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Project.Model.Product", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("invrntoryLevel")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("price")
                        .HasColumnType("real");

                    b.HasKey("id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Project.Model.Transaction_item", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Quintity")
                        .HasColumnType("int");

                    b.Property<int?>("orderid")
                        .HasColumnType("int");

                    b.Property<int?>("productid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("orderid");

                    b.HasIndex("productid");

                    b.ToTable("Transaction_items");
                });

            modelBuilder.Entity("Project.Model.Company", b =>
                {
                    b.HasBaseType("Project.Model.Customer");

                    b.Property<string>("Company_type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Company");
                });

            modelBuilder.Entity("Project.Model.Single_User", b =>
                {
                    b.HasBaseType("Project.Model.Customer");

                    b.Property<string>("Sex")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.HasDiscriminator().HasValue("Single_User");
                });

            modelBuilder.Entity("Project.Model.Order", b =>
                {
                    b.HasOne("Project.Model.Customer", "ord_cus")
                        .WithMany()
                        .HasForeignKey("ord_cusid");

                    b.Navigation("ord_cus");
                });

            modelBuilder.Entity("Project.Model.Transaction_item", b =>
                {
                    b.HasOne("Project.Model.Order", "order")
                        .WithMany()
                        .HasForeignKey("orderid");

                    b.HasOne("Project.Model.Product", "product")
                        .WithMany()
                        .HasForeignKey("productid");

                    b.Navigation("order");

                    b.Navigation("product");
                });
#pragma warning restore 612, 618
        }
    }
}
