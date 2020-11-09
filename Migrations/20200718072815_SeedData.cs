using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PhoneWeb.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "12a9dbbd-faa7-4c31-9c4b-433bdaed8dd2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "394a43f2-7a8f-4134-9244-cfe268d1d3ea");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0e2fd77a-77a5-41cd-9caf-0875c44b1c3e", "6f69c9ce-51d0-4648-944f-c8b2d50af32d", "Visitor", "VISITOR" },
                    { "59c96211-4c67-430c-a9cd-41111ff9eb6c", "0eec0704-6dd4-4125-81f6-5423fa25471a", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2020, 7, 18, 14, 28, 15, 101, DateTimeKind.Local).AddTicks(7419));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2020, 7, 18, 14, 28, 15, 102, DateTimeKind.Local).AddTicks(5085));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2020, 7, 18, 14, 28, 15, 102, DateTimeKind.Local).AddTicks(5113));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2020, 7, 18, 14, 28, 15, 102, DateTimeKind.Local).AddTicks(5115));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2020, 7, 18, 14, 28, 15, 102, DateTimeKind.Local).AddTicks(5117));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2020, 7, 18, 14, 28, 15, 102, DateTimeKind.Local).AddTicks(5119));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2020, 7, 18, 14, 28, 15, 102, DateTimeKind.Local).AddTicks(5121));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2020, 7, 18, 14, 28, 15, 102, DateTimeKind.Local).AddTicks(5122));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2020, 7, 18, 14, 28, 15, 102, DateTimeKind.Local).AddTicks(5124));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2020, 7, 18, 14, 28, 15, 102, DateTimeKind.Local).AddTicks(5125));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTime(2020, 7, 18, 14, 28, 15, 102, DateTimeKind.Local).AddTicks(5127));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTime(2020, 7, 18, 14, 28, 15, 102, DateTimeKind.Local).AddTicks(5128));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTime(2020, 7, 18, 14, 28, 15, 102, DateTimeKind.Local).AddTicks(5130));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14,
                column: "CreateDate",
                value: new DateTime(2020, 7, 18, 14, 28, 15, 102, DateTimeKind.Local).AddTicks(5131));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 15,
                column: "CreateDate",
                value: new DateTime(2020, 7, 18, 14, 28, 15, 102, DateTimeKind.Local).AddTicks(5132));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 16,
                column: "CreateDate",
                value: new DateTime(2020, 7, 18, 14, 28, 15, 102, DateTimeKind.Local).AddTicks(5134));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 17,
                column: "CreateDate",
                value: new DateTime(2020, 7, 18, 14, 28, 15, 102, DateTimeKind.Local).AddTicks(5135));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 18,
                column: "CreateDate",
                value: new DateTime(2020, 7, 18, 14, 28, 15, 102, DateTimeKind.Local).AddTicks(5136));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 19,
                column: "CreateDate",
                value: new DateTime(2020, 7, 18, 14, 28, 15, 102, DateTimeKind.Local).AddTicks(5138));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 20,
                column: "CreateDate",
                value: new DateTime(2020, 7, 18, 14, 28, 15, 102, DateTimeKind.Local).AddTicks(5139));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 21,
                column: "CreateDate",
                value: new DateTime(2020, 7, 18, 14, 28, 15, 102, DateTimeKind.Local).AddTicks(5141));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 22,
                column: "CreateDate",
                value: new DateTime(2020, 7, 18, 14, 28, 15, 102, DateTimeKind.Local).AddTicks(5143));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 23,
                column: "CreateDate",
                value: new DateTime(2020, 7, 18, 14, 28, 15, 102, DateTimeKind.Local).AddTicks(5144));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0e2fd77a-77a5-41cd-9caf-0875c44b1c3e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "59c96211-4c67-430c-a9cd-41111ff9eb6c");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "12a9dbbd-faa7-4c31-9c4b-433bdaed8dd2", "8bbd268a-826a-43d0-8ad1-1c078e512673", "Visitor", "VISITOR" },
                    { "394a43f2-7a8f-4134-9244-cfe268d1d3ea", "b7866438-eea5-410b-acfa-1288348b30e6", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2020, 7, 18, 14, 27, 48, 599, DateTimeKind.Local).AddTicks(3597));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2020, 7, 18, 14, 27, 48, 600, DateTimeKind.Local).AddTicks(1287));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2020, 7, 18, 14, 27, 48, 600, DateTimeKind.Local).AddTicks(1315));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2020, 7, 18, 14, 27, 48, 600, DateTimeKind.Local).AddTicks(1318));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2020, 7, 18, 14, 27, 48, 600, DateTimeKind.Local).AddTicks(1320));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2020, 7, 18, 14, 27, 48, 600, DateTimeKind.Local).AddTicks(1322));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2020, 7, 18, 14, 27, 48, 600, DateTimeKind.Local).AddTicks(1324));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2020, 7, 18, 14, 27, 48, 600, DateTimeKind.Local).AddTicks(1326));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2020, 7, 18, 14, 27, 48, 600, DateTimeKind.Local).AddTicks(1327));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2020, 7, 18, 14, 27, 48, 600, DateTimeKind.Local).AddTicks(1329));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTime(2020, 7, 18, 14, 27, 48, 600, DateTimeKind.Local).AddTicks(1331));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTime(2020, 7, 18, 14, 27, 48, 600, DateTimeKind.Local).AddTicks(1333));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTime(2020, 7, 18, 14, 27, 48, 600, DateTimeKind.Local).AddTicks(1334));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14,
                column: "CreateDate",
                value: new DateTime(2020, 7, 18, 14, 27, 48, 600, DateTimeKind.Local).AddTicks(1336));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 15,
                column: "CreateDate",
                value: new DateTime(2020, 7, 18, 14, 27, 48, 600, DateTimeKind.Local).AddTicks(1337));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 16,
                column: "CreateDate",
                value: new DateTime(2020, 7, 18, 14, 27, 48, 600, DateTimeKind.Local).AddTicks(1338));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 17,
                column: "CreateDate",
                value: new DateTime(2020, 7, 18, 14, 27, 48, 600, DateTimeKind.Local).AddTicks(1340));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 18,
                column: "CreateDate",
                value: new DateTime(2020, 7, 18, 14, 27, 48, 600, DateTimeKind.Local).AddTicks(1341));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 19,
                column: "CreateDate",
                value: new DateTime(2020, 7, 18, 14, 27, 48, 600, DateTimeKind.Local).AddTicks(1343));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 20,
                column: "CreateDate",
                value: new DateTime(2020, 7, 18, 14, 27, 48, 600, DateTimeKind.Local).AddTicks(1344));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 21,
                column: "CreateDate",
                value: new DateTime(2020, 7, 18, 14, 27, 48, 600, DateTimeKind.Local).AddTicks(1345));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 22,
                column: "CreateDate",
                value: new DateTime(2020, 7, 18, 14, 27, 48, 600, DateTimeKind.Local).AddTicks(1347));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 23,
                column: "CreateDate",
                value: new DateTime(2020, 7, 18, 14, 27, 48, 600, DateTimeKind.Local).AddTicks(1348));
        }
    }
}
