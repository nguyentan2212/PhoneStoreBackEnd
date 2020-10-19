using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PhoneStoreBackEnd.Migrations
{
    public partial class InitialCreate : Migration
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
                    Discriminator = table.Column<string>(nullable: false),
                    FullName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Phones",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(type: "money", nullable: false),
                    Image = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phones", x => x.Id);
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

            migrationBuilder.InsertData(
                table: "Phones",
                columns: new[] { "Id", "Image", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "https://cdn.tgdd.vn/Products/Images/42/220522/Feature/samsung-galaxy-note-20-ultra-spec-fixed-720x333.jpg", "Samsung Galaxy Note 20 Ultra", 29990000.0m },
                    { 26, "https://cdn.tgdd.vn/Products/Images/42/206176/samsung-galaxy-note-10-plus-171220-101247-400x400.jpg", "Samsung Galaxy Note 10+", 15990000.0m },
                    { 25, "https://cdn.tgdd.vn/Products/Images/42/223290/vivo-x50-pro-155920-035955-200x200.jpg", "Vivo X50 Pro", 18990000.0m },
                    { 24, "https://cdn.tgdd.vn/Products/Images/42/217935/samsung-galaxy-s20-600x600-hong-400x400.jpg", "Samsung Galaxy S20", 21490000.0m },
                    { 23, "https://cdn.tgdd.vn/Products/Images/42/210644/iphone-11-128gb-green-400x400.jpg", "iPhone 11 128GB", 21990000.0m },
                    { 22, "https://cdn.tgdd.vn/Products/Images/42/198150/oppo-find-x2-blue-600x600-400x400.jpg", "OPPO Find X2", 19990000.0m },
                    { 21, "https://cdn.tgdd.vn/Products/Images/42/214638/oneplus-8-pro-1-200x200.jpg", "OnePlus 8 Pro 5G", 22990000.0m },
                    { 20, "https://cdn.tgdd.vn/Products/Images/42/215773/huawei-p40-pro-600x600-3-400x400.jpg", "Huawei P40 Pro (Nền tảng Huawei Mobile Service)", 21990000.0m },
                    { 19, "https://cdn.tgdd.vn/Products/Images/42/218355/samsung-galaxy-note-20-062220-122200-400x400.jpg", "Samsung Galaxy Note 20", 23990000.0m },
                    { 18, "https://cdn.tgdd.vn/Products/Images/42/217936/samsung-galaxy-s20-plus-600x600-fix-400x400.jpg", "Samsung Galaxy S20+", 16990000.0m },
                    { 17, "https://cdn.tgdd.vn/Products/Images/42/210648/iphone-11-256gb-black-400x400.jpg", "iPhone 11 256GB", 23990000.0m },
                    { 16, "https://cdn.tgdd.vn/Products/Images/42/188705/iphone-11-pro-black-400x400.jpg", "iPhone 11 Pro 64GB", 27990000.0m },
                    { 15, "https://cdn.tgdd.vn/Products/Images/42/200533/iphone-11-pro-max-green-400x400.jpg", "iPhone 11 Pro Max 64GB", 30990000.0m },
                    { 14, "https://cdn.tgdd.vn/Products/Images/42/210655/iphone-11-pro-256gb-black-400x400.jpg", "iPhone 11 Pro 256GB", 31990000.0m },
                    { 13, "https://cdn.tgdd.vn/Products/Images/42/225063/samsung-galaxy-note-20-ultra-5g-063420-123447-400x400.jpg", "Samsung Galaxy Note 20 Ultra 5G", 32990000.0m },
                    { 12, "https://cdn.tgdd.vn/Products/Images/42/210653/iphone-11-pro-max-256gb-black-400x400.jpg", "iPhone 11 Pro Max 256GB", 34990000.0m },
                    { 11, "https://cdn.tgdd.vn/Products/Images/42/213022/samsung-galaxy-z-flip-den-600x600-400x400.jpg", "Samsung Galaxy Z Flip", 36000000.0m },
                    { 10, "https://cdn.tgdd.vn/Products/Images/42/210654/iphone-11-pro-max-512gb-gold-400x400.jpg", "iPhone 11 Pro Max 512GB", 38990000.0m },
                    { 9, "https://cdn.tgdd.vn/Products/Images/42/226099/samsung-galaxy-z-fold-2-061220-021232-200x200.jpg", "Samsung Galaxy Z Fold2 5G", 50000000.0m },
                    { 8, "https://cdn.tgdd.vn/Products/Images/42/228888/vsmart-joy-4-4gb-64gb-171020-021003-400x400.jpg", "Vsmart Joy 4 (4GB/64GB)", 3590000.0m },
                    { 7, "https://cdn.tgdd.vn/Products/Images/42/227689/realme-7-pro-043220-013244-400x400.jpg", "Realme 7 Pro", 8490000.0m },
                    { 6, "https://cdn.tgdd.vn/Products/Images/42/219314/samsung-galaxy-a21s-055620-045659-400x400.jpg", "Samsung Galaxy A21s (6GB/64GB)", 4830000.0m },
                    { 5, "https://cdn.tgdd.vn/Products/Images/42/220654/Feature/1602154414868-720x333.png", "OPPO A92", 5940000.0m },
                    { 4, "https://cdn.tgdd.vn/Products/Images/42/217308/xiaomi-redmi-9-114620-094644-400x400.jpg", "Xiaomi Redmi 9 (4GB/64GB)", 3590000.0m },
                    { 3, "https://cdn.tgdd.vn/Products/Images/42/153856/iphone-11-red-400x400.jpg", "iPhone 11 64GB", 19990000.0m },
                    { 2, "https://cdn.tgdd.vn/Products/Images/42/229056/oppo-a93-230520-060532-200x200.jpg", "OPPO A93", 7490000.0m },
                    { 27, "https://cdn.tgdd.vn/Products/Images/42/190323/iphone-xs-gold-600x600-2-400x400.jpg", "iPhone Xs 64GB", 17990000.0m },
                    { 28, "https://cdn.tgdd.vn/Products/Images/42/222631/iphone-se-256gb-2020-261920-101916-200x200.jpg", "iPhone SE 256GB (2020)", 17990000.0m }
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
                name: "Phones");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
