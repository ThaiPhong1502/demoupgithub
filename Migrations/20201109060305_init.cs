using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PhoneWeb.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderDate = table.Column<DateTime>(nullable: false),
                    TenKhachHang = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    SoDienThoai = table.Column<string>(maxLength: 10, nullable: true),
                    DiaChiGiaoHang = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(nullable: false),
                    ProductQuantity = table.Column<int>(nullable: false),
                    ProductImage = table.Column<string>(nullable: true),
                    ProductPrice = table.Column<double>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    Descriptions = table.Column<string>(nullable: true),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    OrderDetailId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(nullable: false),
                    ProductId = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.OrderDetailId);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "22cd9b5a-5d3f-47f9-b9fc-b2ebd3b3abd7", "d8241432-dabe-4f12-9561-4df27c757419", "Visitor", "VISITOR" },
                    { "9caebed3-8895-4962-9704-7fcbe85e4721", "a3619f5d-977c-4220-91d9-a44c16e16a35", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[,]
                {
                    { 1, "Áo Thun Ngắn Tay" },
                    { 2, "Áo Thun Dài Tay" },
                    { 3, "Áo Thun Cổ" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "CreateDate", "Descriptions", "ProductImage", "ProductName", "ProductPrice", "ProductQuantity" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2020, 11, 9, 13, 3, 4, 695, DateTimeKind.Local).AddTicks(3964), "Chất liệu: Cotton 2 chiều, Thành phần: 100% Cotton,  Co dãn 2 chiều, Thấm hút mồ hôi tốt mang lại cảm giác thoáng mái, Họa tiết: ép Foil ", "1.jpg", "Áo Thun TN R Thiết Kế BD-A93", 300000.0, 100 },
                    { 2, 1, new DateTime(2020, 11, 9, 13, 3, 4, 696, DateTimeKind.Local).AddTicks(7148), "Chất liệu: Cotton 2 chiều, Thành phần: 100% Cotton, Co dãn 2 chiều, Thấm hút mồ hôi tốt mang lại cảm giác thoáng mát ", "2.jpg", "Áo Thun TN TC Đơn Giản BN01", 300000.0, 100 },
                    { 3, 1, new DateTime(2020, 11, 9, 13, 3, 4, 696, DateTimeKind.Local).AddTicks(7177), "Chất liệu: Cotton 4 Chiều, Thành phần: 95% cotton 5% Spandex, Co giãn tốt, Độ bền cao ", "3.jpg", "Áo Thun Cổ Trụ TC Đơn Giản J01", 300000.0, 100 },
                    { 4, 1, new DateTime(2020, 11, 9, 13, 3, 4, 696, DateTimeKind.Local).AddTicks(7181), "Chất liệu: Cotton 2 chiều, Thành phần: 100% Cotton, Co dãn 2 chiều, Thấm hút mồ hôi tốt mang lại cảm giác thoáng mái, Họa tiết: in trame, in dẻo ", "4.jpg", "Áo Thun TN R Thiết Kế BO01", 300000.0, 100 },
                    { 5, 1, new DateTime(2020, 11, 9, 13, 3, 4, 696, DateTimeKind.Local).AddTicks(7183), "Chất liệu: Cotton 2 chiều, Thành phần: 100% Cotton, Co dãn 2 chiều, Thấm hút mồ hôi tốt mang lại cảm giác thoáng mái, Họa tiết: in trame ", "5.jpg", "Áo Thun TN R Thiết Kế BD-A90", 300000.0, 100 },
                    { 6, 2, new DateTime(2020, 11, 9, 13, 3, 4, 696, DateTimeKind.Local).AddTicks(7186), "Chất liệu: Cotton 2 chiều, Thành phần: 100% Cotton, Co dãn 2 chiều, Thấm hút mồ hôi tốt mang lại cảm giác thoáng mát ", "6.jpg", "Áo Thun TN TC Thiết Kế B1CF06", 250000.0, 100 },
                    { 7, 2, new DateTime(2020, 11, 9, 13, 3, 4, 696, DateTimeKind.Local).AddTicks(7188), "Chất liệu: Cotton 2 chiều, Thành phần: 100% Cotton,  Co dãn 2 chiều, Thấm hút mồ hôi tốt mang lại cảm giác thoáng mái, Họa tiết: ép Foil ", "7.jpg", "Áo Thun TD R Thiết Kế A02", 250000.0, 100 },
                    { 8, 2, new DateTime(2020, 11, 9, 13, 3, 4, 696, DateTimeKind.Local).AddTicks(7190), "Chất liệu: Cotton 2 chiều, Thành phần: 100% Cotton, Co dãn 2 chiều, Thấm hút mồ hôi tốt mang lại cảm giác thoáng mát ", "8.jpg", "Áo Thun TD R Thiết Kế B02", 250000.0, 100 },
                    { 9, 2, new DateTime(2020, 11, 9, 13, 3, 4, 696, DateTimeKind.Local).AddTicks(7192), "COUPLE TAY DÀI, Diện áo thun couple đã trở thành xu hướng của giới trẻ hiện đại, Đặc biệt áo thun tay dài raplan, màu sắc tươi mới, Thiết kế Unisex, dễ dàng mix với nhiều trang phục khác nhau, Chất liệu cotton 2 chiều, thoáng mát, bề mặt mịn đẹp ", "9.jpg", "Áo Thun TD TC Đơn Giản B4AA01", 250000.0, 100 },
                    { 10, 2, new DateTime(2020, 11, 9, 13, 3, 4, 696, DateTimeKind.Local).AddTicks(7195), "COUPLE TAY DÀI, Diện áo thun couple đã trở thành xu hướng của giới trẻ hiện đại, Đặc biệt áo thun tay dài raplan, màu sắc tươi mới, Thiết kế Unisex, dễ dàng mix với nhiều trang phục khác nhau, Chất liệu cotton 2 chiều, thoáng mát, bề mặt mịn đẹp ", "10.jpg", "Samsung Galaxy A71", 250000.0, 100 },
                    { 11, 3, new DateTime(2020, 11, 9, 13, 3, 4, 696, DateTimeKind.Local).AddTicks(7338), "COUPLE TAY DÀI, Diện áo thun couple đã trở thành xu hướng của giới trẻ hiện đại, Đặc biệt áo thun tay dài raplan, màu sắc tươi mới, Thiết kế Unisex, dễ dàng mix với nhiều trang phục khác nhau, Chất liệu cotton 2 chiều, thoáng mát, bề mặt mịn đẹp ", "11.jpg", "Áo Thun Cổ Trụ TC Đơn Giản B2R01", 250000.0, 100 },
                    { 12, 3, new DateTime(2020, 11, 9, 13, 3, 4, 696, DateTimeKind.Local).AddTicks(7341), "COUPLE TAY DÀI, Diện áo thun couple đã trở thành xu hướng của giới trẻ hiện đại, Đặc biệt áo thun tay dài raplan, màu sắc tươi mới, Thiết kế Unisex, dễ dàng mix với nhiều trang phục khác nhau, Chất liệu cotton 2 chiều, thoáng mát, bề mặt mịn đẹp ", "12.jpg", "Áo Thun Cổ Trụ TC Thiết Kế B2R04", 250000.0, 100 },
                    { 13, 3, new DateTime(2020, 11, 9, 13, 3, 4, 696, DateTimeKind.Local).AddTicks(7343), "COUPLE TAY DÀI, Diện áo thun couple đã trở thành xu hướng của giới trẻ hiện đại, Đặc biệt áo thun tay dài raplan, màu sắc tươi mới, Thiết kế Unisex, dễ dàng mix với nhiều trang phục khác nhau, Chất liệu cotton 2 chiều, thoáng mát, bề mặt mịn đẹp ", "13.jpg", "Áo Thun Cổ Trụ TC Thiết Kế B04", 250000.0, 100 },
                    { 14, 3, new DateTime(2020, 11, 9, 13, 3, 4, 696, DateTimeKind.Local).AddTicks(7345), "COUPLE TAY DÀI, Diện áo thun couple đã trở thành xu hướng của giới trẻ hiện đại, Đặc biệt áo thun tay dài raplan, màu sắc tươi mới, Thiết kế Unisex, dễ dàng mix với nhiều trang phục khác nhau, Chất liệu cotton 2 chiều, thoáng mát, bề mặt mịn đẹp ", "14.jpg", "Áo Thun Cổ Trụ TC Thiết Kế B1Q02", 250000.0, 100 },
                    { 15, 3, new DateTime(2020, 11, 9, 13, 3, 4, 696, DateTimeKind.Local).AddTicks(7347), "COUPLE TAY DÀI, Diện áo thun couple đã trở thành xu hướng của giới trẻ hiện đại, Đặc biệt áo thun tay dài raplan, màu sắc tươi mới, Thiết kế Unisex, dễ dàng mix với nhiều trang phục khác nhau, Chất liệu cotton 2 chiều, thoáng mát, bề mặt mịn đẹp ", "15.jpg", "Áo Thun Cổ Trụ TC Thiết Kế F01", 250000.0, 100 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderId",
                table: "OrderDetails",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_ProductId",
                table: "OrderDetails",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
