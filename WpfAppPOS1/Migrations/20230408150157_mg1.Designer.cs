﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WpfAppPOS1.Models;

#nullable disable

namespace WpfAppPOS1.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20230408150157_mg1")]
    partial class mg1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.4");

            modelBuilder.Entity("WpfAppPOS1.Models.CartItem", b =>
                {
                    b.Property<int>("CartItemID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Discount")
                        .HasColumnType("TEXT");

                    b.Property<int>("InvoiceID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProductID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("TEXT");

                    b.HasKey("CartItemID");

                    b.HasIndex("InvoiceID");

                    b.ToTable("CartItem");
                });

            modelBuilder.Entity("WpfAppPOS1.Models.Invoice", b =>
                {
                    b.Property<int>("InvoiceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("AmountTendered")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Change")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Total")
                        .HasColumnType("TEXT");

                    b.HasKey("InvoiceID");

                    b.ToTable("Invoices");
                });

            modelBuilder.Entity("WpfAppPOS1.Models.Product", b =>
                {
                    b.Property<int>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("QuantityInStock")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("TEXT");

                    b.HasKey("ProductID");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("WpfAppPOS1.Models.Stock", b =>
                {
                    b.Property<int>("StockId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("CostPrice")
                        .HasColumnType("REAL");

                    b.Property<DateTime>("LastUpdated")
                        .HasColumnType("TEXT");

                    b.Property<int>("ProductID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.Property<double>("SellingPrice")
                        .HasColumnType("REAL");

                    b.HasKey("StockId");

                    b.ToTable("Stocks");
                });

            modelBuilder.Entity("WpfAppPOS1.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("BLOB");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("BLOB");

                    b.Property<int>("Phone")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 2,
                            FirstName = "Default",
                            IsAdmin = true,
                            LastName = "Admin",
                            PasswordHash = new byte[] { 169, 33, 67, 51, 211, 190, 22, 69, 222, 250, 177, 212, 210, 33, 219, 136, 26, 190, 12, 122, 22, 225, 78, 229, 44, 139, 94, 97, 234, 167, 42, 221, 108, 64, 26, 110, 229, 168, 99, 52, 194, 214, 102, 168, 238, 197, 46, 70, 239, 51, 45, 116, 209, 175, 177, 149, 22, 186, 200, 120, 3, 246, 207, 138 },
                            PasswordSalt = new byte[] { 30, 74, 97, 140, 43, 166, 166, 221, 149, 94, 254, 218, 196, 34, 244, 192, 85, 52, 228, 118, 100, 56, 83, 46, 243, 41, 142, 93, 26, 3, 206, 199, 12, 200, 71, 3, 54, 111, 203, 95, 99, 108, 144, 227, 249, 167, 69, 7, 65, 171, 248, 25, 56, 75, 31, 108, 11, 194, 2, 168, 190, 168, 151, 120, 238, 209, 147, 209, 235, 90, 82, 142, 159, 219, 161, 13, 146, 173, 168, 87, 168, 10, 117, 47, 69, 134, 19, 102, 90, 174, 85, 78, 192, 74, 212, 147, 190, 199, 11, 98, 219, 219, 73, 94, 172, 124, 241, 132, 224, 232, 90, 17, 157, 117, 101, 42, 135, 4, 129, 102, 50, 28, 169, 100, 95, 246, 215, 196 },
                            Phone = 123456789,
                            Username = "admin"
                        });
                });

            modelBuilder.Entity("WpfAppPOS1.Models.CartItem", b =>
                {
                    b.HasOne("WpfAppPOS1.Models.Invoice", null)
                        .WithMany("CartItems")
                        .HasForeignKey("InvoiceID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WpfAppPOS1.Models.Invoice", b =>
                {
                    b.Navigation("CartItems");
                });
#pragma warning restore 612, 618
        }
    }
}
