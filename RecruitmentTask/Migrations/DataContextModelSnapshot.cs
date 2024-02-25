﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RecruitmentTask.Data;

#nullable disable

namespace RecruitmentTask.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("RecruitmentTaskShared.Entities.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(24)
                        .HasColumnType("nvarchar(24)");

                    b.Property<int>("NIP")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(16)
                        .HasColumnType("nvarchar(16)");

                    b.HasKey("Id");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "AeAxXjS7k8bc8II6y",
                            NIP = 2078457332,
                            Name = "4REcCHpxNY"
                        },
                        new
                        {
                            Id = 2,
                            Address = "0DLedvUa1HBuVXkgtz1Tj2p",
                            NIP = 2012551828,
                            Name = "YHEaWPBFSHhU0"
                        },
                        new
                        {
                            Id = 3,
                            Address = "Qrj6ZnOfQEiQO0VwyESVUi",
                            NIP = 1727280301,
                            Name = "xMSfT"
                        },
                        new
                        {
                            Id = 4,
                            Address = "IU2hyCyuQ",
                            NIP = 1059578853,
                            Name = "EeljfYCqNzg"
                        },
                        new
                        {
                            Id = 5,
                            Address = "Bmr",
                            NIP = 2031160686,
                            Name = "fxkPwcXh"
                        },
                        new
                        {
                            Id = 6,
                            Address = "IkAlahM4BI6c6rHwyyhl8nUE",
                            NIP = 1374818396,
                            Name = "6c3v"
                        },
                        new
                        {
                            Id = 7,
                            Address = "XhcPeiaWp",
                            NIP = 1081249159,
                            Name = "RumIwaHgXXbf"
                        },
                        new
                        {
                            Id = 8,
                            Address = "npqowVHjt9IgaP3yJVhChXCV",
                            NIP = 2075394150,
                            Name = "NNTvuH"
                        },
                        new
                        {
                            Id = 9,
                            Address = "p2bl",
                            NIP = 1119342140,
                            Name = "ih3pzPoc2pZw"
                        },
                        new
                        {
                            Id = 10,
                            Address = "EZZdGChUx6CQg",
                            NIP = 1630163947,
                            Name = "El3wXmGNs3DxdCG"
                        },
                        new
                        {
                            Id = 11,
                            Address = "S58FPbeRRawQRcYyT6",
                            NIP = 1511702707,
                            Name = "9fsgqtCRL4PFVl"
                        },
                        new
                        {
                            Id = 12,
                            Address = "iX2jVotGqu3JPJGuhdQA6FQP",
                            NIP = 1923366677,
                            Name = "FWd"
                        },
                        new
                        {
                            Id = 13,
                            Address = "P79xRb3kxeOisooS5nq97",
                            NIP = 1634220317,
                            Name = "Ze2QRsBN2E"
                        },
                        new
                        {
                            Id = 14,
                            Address = "n0DYFSctac",
                            NIP = 1110810929,
                            Name = "s1QAh"
                        },
                        new
                        {
                            Id = 15,
                            Address = "JXUBChXEYYsdyLg1xN",
                            NIP = 1740463946,
                            Name = "5it"
                        },
                        new
                        {
                            Id = 16,
                            Address = "RXI2Ew2kk",
                            NIP = 1558406840,
                            Name = "4k7MZ4IMM"
                        },
                        new
                        {
                            Id = 17,
                            Address = "So8drLEchnRvwpfMAvmbbc",
                            NIP = 1154040842,
                            Name = "js5"
                        },
                        new
                        {
                            Id = 18,
                            Address = "MkACpoM52f",
                            NIP = 1340631952,
                            Name = "zn1TeWegHWCN7WwC"
                        },
                        new
                        {
                            Id = 19,
                            Address = "iBWmPQhM8WqG64vD",
                            NIP = 1460925941,
                            Name = "g0Dc6nX"
                        },
                        new
                        {
                            Id = 20,
                            Address = "rN3smWJKau0FZ3",
                            NIP = 1517114588,
                            Name = "BOHnJrEsq1nBtKgJ"
                        },
                        new
                        {
                            Id = 21,
                            Address = "yEktxwE0p6xYWOp95",
                            NIP = 1811070209,
                            Name = "RbnupRwgVl"
                        },
                        new
                        {
                            Id = 22,
                            Address = "Or57BNIvGlSYl3DjXYoq",
                            NIP = 1996737270,
                            Name = "bjoasom"
                        },
                        new
                        {
                            Id = 23,
                            Address = "0LBV",
                            NIP = 1836721142,
                            Name = "Ob5512c6N4L5bnVw"
                        },
                        new
                        {
                            Id = 24,
                            Address = "aJaggT2",
                            NIP = 1697483244,
                            Name = "A0E"
                        },
                        new
                        {
                            Id = 25,
                            Address = "9pQFdKlf2kWf1",
                            NIP = 1172952086,
                            Name = "lNu9UgQWEZhgu"
                        },
                        new
                        {
                            Id = 26,
                            Address = "YlnMkA",
                            NIP = 1983675964,
                            Name = "MnNM2cdnSx6"
                        },
                        new
                        {
                            Id = 27,
                            Address = "559OQXnF",
                            NIP = 1846569052,
                            Name = "U0WqScL0y3l"
                        },
                        new
                        {
                            Id = 28,
                            Address = "AYWUW6w0pt",
                            NIP = 1410498646,
                            Name = "amlRxGrW5Kq"
                        },
                        new
                        {
                            Id = 29,
                            Address = "IppEE6zTYZ",
                            NIP = 1128045951,
                            Name = "U8sWDhcnEio"
                        },
                        new
                        {
                            Id = 30,
                            Address = "Glwdt0KjvzZ5bu",
                            NIP = 2061897924,
                            Name = "bfX"
                        },
                        new
                        {
                            Id = 31,
                            Address = "d7MHhlxnnl6AaUzQ",
                            NIP = 1061635456,
                            Name = "Pc29ByLjzdFRb"
                        },
                        new
                        {
                            Id = 32,
                            Address = "uypQnrYoHu1qm",
                            NIP = 1862229501,
                            Name = "eUBUgj7CI9668u2"
                        },
                        new
                        {
                            Id = 33,
                            Address = "guPXO80CmgkRD26rsuLlwK",
                            NIP = 1381438553,
                            Name = "vA5DcZorD4n"
                        },
                        new
                        {
                            Id = 34,
                            Address = "QPAHwspVqvd",
                            NIP = 1400135104,
                            Name = "WkAN0yrI"
                        },
                        new
                        {
                            Id = 35,
                            Address = "g9fgRzVRs5rY",
                            NIP = 1851474253,
                            Name = "fOY9kZR"
                        },
                        new
                        {
                            Id = 36,
                            Address = "94hQiMHLoSKkZUIHBsV1aVn",
                            NIP = 1973653641,
                            Name = "iJRt"
                        },
                        new
                        {
                            Id = 37,
                            Address = "Xs2nc29PYgoK",
                            NIP = 1655848170,
                            Name = "5CVgN5mPnzM9S"
                        },
                        new
                        {
                            Id = 38,
                            Address = "6lqsmWfAMpMnM7jTo5mjRs",
                            NIP = 2041808808,
                            Name = "fCrBfj"
                        },
                        new
                        {
                            Id = 39,
                            Address = "kDr86",
                            NIP = 1121459911,
                            Name = "xfnkFNeIISd2y"
                        },
                        new
                        {
                            Id = 40,
                            Address = "usS1yXc5q5ZA8rxE2",
                            NIP = 1794236557,
                            Name = "OKWwc8inmJYDuf"
                        },
                        new
                        {
                            Id = 41,
                            Address = "9DHaQ54K8ZEuM9CBw",
                            NIP = 1412433519,
                            Name = "WND7GZ7f4pRUP7"
                        },
                        new
                        {
                            Id = 42,
                            Address = "58xjhdfwC",
                            NIP = 1635570218,
                            Name = "2S3yuratTFO"
                        },
                        new
                        {
                            Id = 43,
                            Address = "NvDsMRN7IRNm9TDWscj",
                            NIP = 1729418110,
                            Name = "yNRRQfLlq"
                        },
                        new
                        {
                            Id = 44,
                            Address = "WA6DJEEuFrmi5iCpt0",
                            NIP = 1287783218,
                            Name = "cSi3iqx"
                        },
                        new
                        {
                            Id = 45,
                            Address = "zebMt0PVXc9",
                            NIP = 1429560041,
                            Name = "VMnH"
                        },
                        new
                        {
                            Id = 46,
                            Address = "OJFoO",
                            NIP = 1710772738,
                            Name = "LG39TG"
                        },
                        new
                        {
                            Id = 47,
                            Address = "z042SW2jguKGc6WCUby2s",
                            NIP = 1245979881,
                            Name = "fsuvEOXiEJu0T"
                        },
                        new
                        {
                            Id = 48,
                            Address = "pU9HbgFTBms9UVrf0lD2huwD",
                            NIP = 1497974264,
                            Name = "5K8oABQ"
                        },
                        new
                        {
                            Id = 49,
                            Address = "RSLj",
                            NIP = 1209570895,
                            Name = "ClidLoIgR"
                        },
                        new
                        {
                            Id = 50,
                            Address = "GpejaBuliV8gXGJsZgAzw",
                            NIP = 1777200807,
                            Name = "Nj6Zzpzp"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
