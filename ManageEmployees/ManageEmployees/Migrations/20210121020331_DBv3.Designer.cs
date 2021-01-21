﻿// <auto-generated />
using ManageEmployees.Models.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ManageEmployees.Migrations
{
    [DbContext(typeof(EmployeesDbContext))]
    [Migration("20210121020331_DBv3")]
    partial class DBv3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("ManageEmployees.Models.Entities.Employees", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Department")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Department = "Phòng Kế toán",
                            Image = "Do-thi-chan-hoa.jpg",
                            Name = "Đổ Thị Chan Hòa",
                            Phone = "012369856"
                        },
                        new
                        {
                            ID = 2,
                            Department = "Phòng bảo vệ",
                            Image = "Tuan.jpg",
                            Name = "Phạm Tuân",
                            Phone = "012369856"
                        },
                        new
                        {
                            ID = 3,
                            Department = "Phòng bảo vệ",
                            Image = "Vu-quang-huy.jpg",
                            Name = "Vũ Quang Huy",
                            Phone = "012369856"
                        },
                        new
                        {
                            ID = 4,
                            Department = "Phòng công nghệ thông tin",
                            Image = "Hieu-icetea.jpg",
                            Name = "Nguyễn Đình Hiếu",
                            Phone = "012369856"
                        },
                        new
                        {
                            ID = 5,
                            Department = "Phòng quản lý",
                            Image = "truong-thanh-tu.jpg",
                            Name = "Trương Thanh Tú",
                            Phone = "012369856"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
