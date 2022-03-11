﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StockTracker.Data;

#nullable disable

namespace StockTracker.Data.Migrations
{
    [DbContext(typeof(StockDbContext))]
    [Migration("20220304215932_M1")]
    partial class M1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.2");

            modelBuilder.Entity("StockTracker.Data.Stock", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ticker")
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("Stocks");

                    b.HasData(
                        new
                        {
                            id = 1,
                            ticker = "GME"
                        },
                        new
                        {
                            id = 2,
                            ticker = "AAPL"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}