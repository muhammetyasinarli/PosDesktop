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
    [Migration("20230526155412_mgg4")]
    partial class mgg4
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

                    b.Property<double>("Discount")
                        .HasColumnType("REAL");

                    b.Property<int>("InvoiceID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProductID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.Property<double>("TotalPrice")
                        .HasColumnType("REAL");

                    b.Property<double>("UnitPrice")
                        .HasColumnType("REAL");

                    b.HasKey("CartItemID");

                    b.HasIndex("InvoiceID");

                    b.HasIndex("ProductID");

                    b.ToTable("CartItems");
                });

            modelBuilder.Entity("WpfAppPOS1.Models.Invoice", b =>
                {
                    b.Property<int>("InvoiceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("AmountTendered")
                        .HasColumnType("REAL");

                    b.Property<double>("Change")
                        .HasColumnType("REAL");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("TEXT");

                    b.Property<double>("Total")
                        .HasColumnType("REAL");

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

                    b.HasIndex("ProductID");

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
                            Id = 1002,
                            FirstName = "Default",
                            IsAdmin = true,
                            LastName = "Admin",
                            PasswordHash = new byte[] { 255, 52, 161, 129, 199, 63, 205, 143, 182, 12, 74, 210, 142, 44, 139, 34, 70, 156, 119, 209, 130, 232, 31, 159, 105, 109, 232, 58, 17, 20, 132, 18, 83, 153, 133, 200, 40, 94, 194, 193, 69, 97, 124, 11, 122, 6, 172, 85, 80, 166, 13, 87, 68, 42, 178, 17, 36, 36, 150, 136, 157, 124, 113, 97 },
                            PasswordSalt = new byte[] { 206, 81, 138, 185, 217, 190, 171, 185, 119, 115, 235, 203, 166, 254, 158, 80, 189, 211, 251, 184, 44, 249, 126, 125, 24, 168, 34, 215, 112, 208, 176, 37, 4, 225, 135, 68, 248, 202, 245, 78, 72, 72, 112, 202, 23, 126, 255, 71, 202, 212, 233, 193, 36, 165, 133, 94, 252, 109, 199, 12, 238, 44, 119, 29, 45, 150, 161, 217, 177, 22, 35, 18, 138, 19, 0, 58, 158, 8, 91, 126, 92, 129, 109, 72, 64, 240, 209, 147, 163, 137, 236, 214, 66, 214, 104, 252, 182, 197, 212, 21, 175, 126, 101, 140, 215, 74, 13, 224, 40, 141, 128, 177, 252, 132, 178, 236, 69, 94, 138, 146, 47, 179, 73, 111, 205, 117, 56, 72 },
                            Phone = 123456789,
                            Username = "admin"
                        });
                });

            modelBuilder.Entity("WpfAppPOS1.Models.CartItem", b =>
                {
                    b.HasOne("WpfAppPOS1.Models.Invoice", "Invoice")
                        .WithMany("CartItems")
                        .HasForeignKey("InvoiceID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WpfAppPOS1.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Invoice");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("WpfAppPOS1.Models.Stock", b =>
                {
                    b.HasOne("WpfAppPOS1.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("WpfAppPOS1.Models.Invoice", b =>
                {
                    b.Navigation("CartItems");
                });
#pragma warning restore 612, 618
        }
    }
}
