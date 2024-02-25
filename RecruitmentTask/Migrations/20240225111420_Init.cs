using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RecruitmentTask.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(24)", maxLength: 24, nullable: false),
                    NIP = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Address", "NIP", "Name" },
                values: new object[,]
                {
                    { 1, "AeAxXjS7k8bc8II6y", 2078457332, "4REcCHpxNY" },
                    { 2, "0DLedvUa1HBuVXkgtz1Tj2p", 2012551828, "YHEaWPBFSHhU0" },
                    { 3, "Qrj6ZnOfQEiQO0VwyESVUi", 1727280301, "xMSfT" },
                    { 4, "IU2hyCyuQ", 1059578853, "EeljfYCqNzg" },
                    { 5, "Bmr", 2031160686, "fxkPwcXh" },
                    { 6, "IkAlahM4BI6c6rHwyyhl8nUE", 1374818396, "6c3v" },
                    { 7, "XhcPeiaWp", 1081249159, "RumIwaHgXXbf" },
                    { 8, "npqowVHjt9IgaP3yJVhChXCV", 2075394150, "NNTvuH" },
                    { 9, "p2bl", 1119342140, "ih3pzPoc2pZw" },
                    { 10, "EZZdGChUx6CQg", 1630163947, "El3wXmGNs3DxdCG" },
                    { 11, "S58FPbeRRawQRcYyT6", 1511702707, "9fsgqtCRL4PFVl" },
                    { 12, "iX2jVotGqu3JPJGuhdQA6FQP", 1923366677, "FWd" },
                    { 13, "P79xRb3kxeOisooS5nq97", 1634220317, "Ze2QRsBN2E" },
                    { 14, "n0DYFSctac", 1110810929, "s1QAh" },
                    { 15, "JXUBChXEYYsdyLg1xN", 1740463946, "5it" },
                    { 16, "RXI2Ew2kk", 1558406840, "4k7MZ4IMM" },
                    { 17, "So8drLEchnRvwpfMAvmbbc", 1154040842, "js5" },
                    { 18, "MkACpoM52f", 1340631952, "zn1TeWegHWCN7WwC" },
                    { 19, "iBWmPQhM8WqG64vD", 1460925941, "g0Dc6nX" },
                    { 20, "rN3smWJKau0FZ3", 1517114588, "BOHnJrEsq1nBtKgJ" },
                    { 21, "yEktxwE0p6xYWOp95", 1811070209, "RbnupRwgVl" },
                    { 22, "Or57BNIvGlSYl3DjXYoq", 1996737270, "bjoasom" },
                    { 23, "0LBV", 1836721142, "Ob5512c6N4L5bnVw" },
                    { 24, "aJaggT2", 1697483244, "A0E" },
                    { 25, "9pQFdKlf2kWf1", 1172952086, "lNu9UgQWEZhgu" },
                    { 26, "YlnMkA", 1983675964, "MnNM2cdnSx6" },
                    { 27, "559OQXnF", 1846569052, "U0WqScL0y3l" },
                    { 28, "AYWUW6w0pt", 1410498646, "amlRxGrW5Kq" },
                    { 29, "IppEE6zTYZ", 1128045951, "U8sWDhcnEio" },
                    { 30, "Glwdt0KjvzZ5bu", 2061897924, "bfX" },
                    { 31, "d7MHhlxnnl6AaUzQ", 1061635456, "Pc29ByLjzdFRb" },
                    { 32, "uypQnrYoHu1qm", 1862229501, "eUBUgj7CI9668u2" },
                    { 33, "guPXO80CmgkRD26rsuLlwK", 1381438553, "vA5DcZorD4n" },
                    { 34, "QPAHwspVqvd", 1400135104, "WkAN0yrI" },
                    { 35, "g9fgRzVRs5rY", 1851474253, "fOY9kZR" },
                    { 36, "94hQiMHLoSKkZUIHBsV1aVn", 1973653641, "iJRt" },
                    { 37, "Xs2nc29PYgoK", 1655848170, "5CVgN5mPnzM9S" },
                    { 38, "6lqsmWfAMpMnM7jTo5mjRs", 2041808808, "fCrBfj" },
                    { 39, "kDr86", 1121459911, "xfnkFNeIISd2y" },
                    { 40, "usS1yXc5q5ZA8rxE2", 1794236557, "OKWwc8inmJYDuf" },
                    { 41, "9DHaQ54K8ZEuM9CBw", 1412433519, "WND7GZ7f4pRUP7" },
                    { 42, "58xjhdfwC", 1635570218, "2S3yuratTFO" },
                    { 43, "NvDsMRN7IRNm9TDWscj", 1729418110, "yNRRQfLlq" },
                    { 44, "WA6DJEEuFrmi5iCpt0", 1287783218, "cSi3iqx" },
                    { 45, "zebMt0PVXc9", 1429560041, "VMnH" },
                    { 46, "OJFoO", 1710772738, "LG39TG" },
                    { 47, "z042SW2jguKGc6WCUby2s", 1245979881, "fsuvEOXiEJu0T" },
                    { 48, "pU9HbgFTBms9UVrf0lD2huwD", 1497974264, "5K8oABQ" },
                    { 49, "RSLj", 1209570895, "ClidLoIgR" },
                    { 50, "GpejaBuliV8gXGJsZgAzw", 1777200807, "Nj6Zzpzp" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
