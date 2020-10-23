using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace PhoneStoreBackEnd.Migrations
{
    public partial class InitialPostgresql : Migration
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
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(type: "money", nullable: false),
                    Image = table.Column<string>(nullable: true),
                    Brand = table.Column<string>(nullable: true),
                    Screen = table.Column<string>(nullable: true),
                    ScreenSize = table.Column<float>(nullable: false),
                    OS = table.Column<string>(nullable: true),
                    RearCamera = table.Column<string>(nullable: true),
                    FrontCamera = table.Column<string>(nullable: true),
                    CPU = table.Column<string>(nullable: true),
                    RAM = table.Column<int>(nullable: false),
                    Storage = table.Column<int>(nullable: false),
                    MemoryCard = table.Column<string>(nullable: true),
                    SIM = table.Column<string>(nullable: true),
                    BatteryCapacity = table.Column<int>(nullable: false),
                    HasQuickCharge = table.Column<bool>(type: "boolean", nullable: false)
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
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
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
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
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
                columns: new[] { "Id", "BatteryCapacity", "Brand", "CPU", "FrontCamera", "HasQuickCharge", "Image", "MemoryCard", "Name", "OS", "Price", "RAM", "RearCamera", "SIM", "Screen", "ScreenSize", "Storage" },
                values: new object[,]
                {
                    { 1, 4500, "Samsung", "Exynos 990 8 nhân", "10 MP", true, "https://cdn.tgdd.vn/Products/Images/42/220522/samsung-galaxy-note-20-ultra-vangdong-400x460-400x460.png", "MicroSD, hỗ trợ tối đa 1 TB", "Điện thoại Samsung Galaxy Note 20 Ultra", "Android 10", 29990000.0m, 8, "Chính 108 MP & Phụ 12 MP, 12 MP, cảm biến Laser AF", "2 Nano SIM hoặc 1 Nano SIM + 1 eSIM, Hỗ trợ 4G", "Dynamic AMOLED 2X, 6.9\", Quad HD+ (2K+)", 6.9f, 256 },
                    { 15, 3969, "iPhone (Apple)", "Apple A13 Bionic 6 nhân", "12 MP", true, "https://cdn.tgdd.vn/Products/Images/42/200533/iphone-11-pro-max-black-400x460.png", null, "Điện thoại iPhone 11 Pro Max 64GB", "iOS 13", 30990000.0m, 4, "3 camera 12 MP", "1 Nano SIM & 1 eSIM, Hỗ trợ 4G", "OLED, 6.5\", Super Retina XDR", 6.5f, 64 },
                    { 14, 3046, "iPhone (Apple)", "Apple A13 Bionic 6 nhân", "12 MP", true, "https://cdn.tgdd.vn/Products/Images/42/210655/iphone-11-pro-256gb-black-400x460.png", null, "Điện thoại iPhone 11 Pro 256GB", "iOS 13", 31990000.0m, 4, "3 camera 12 MP", "1 Nano SIM & 1 eSIM, Hỗ trợ 4G", "OLED, 5.8\", Super Retina XDR", 5.8f, 256 },
                    { 13, 4500, "Samsung", "Exynos 990 8 nhân", "10 MP", true, "https://cdn.tgdd.vn/Products/Images/42/225063/samsung-galaxy-note-20-ultra-5g-vangdong-400x460-400x460.png", "MicroSD, hỗ trợ tối đa 1 TB", "Điện thoại Samsung Galaxy Note 20 Ultra 5G", "Android 10", 32990000.0m, 12, "Chính 108 MP & Phụ 12 MP, 12 MP, cảm biến Laser AF", "2 Nano SIM hoặc 1 Nano SIM + 1 eSIM, Hỗ trợ 5G", "Dynamic AMOLED 2X, 6.9\", Quad HD+ (2K+)", 6.9f, 256 },
                    { 12, 3969, "iPhone (Apple)", "Apple A13 Bionic 6 nhân", "12 MP", true, "https://cdn.tgdd.vn/Products/Images/42/210653/iphone-11-pro-max-256gb-black-400x460.png", null, "Điện thoại iPhone 11 Pro Max 256GB", "iOS 13", 34990000.0m, 4, "3 camera 12 MP", "1 Nano SIM & 1 eSIM, Hỗ trợ 4G", "OLED, 6.5\", Super Retina XDR", 6.5f, 256 },
                    { 11, 0, "Samsung", null, null, false, "https://cdn.tgdd.vn/Products/Images/42/213022/samsung-galaxy-z-flip-chitiet-2-788x544.png", null, "Điện thoại Samsung Galaxy Z Flip", null, 36000000.0m, 0, null, null, "Chính: Dynamic AMOLED, Phụ: Super AMOLED, 6.7\", Quad HD (2K)", 0f, 0 },
                    { 10, 3969, "iPhone (Apple)", "Apple A13 Bionic 6 nhân", "12 MP", true, "https://cdn.tgdd.vn/Products/Images/42/210654/iphone-11-pro-max-512gb-gold-400x460.png", null, "Điện thoại iPhone 11 Pro Max 512GB", "iOS 13", 38990000.0m, 4, "3 camera 12 MP", "1 Nano SIM & 1 eSIM, Hỗ trợ 4G", "OLED, 6.5\", Super Retina XDR", 6.5f, 512 },
                    { 16, 3046, "iPhone (Apple)", "Apple A13 Bionic 6 nhân", "12 MP", true, "https://cdn.tgdd.vn/Products/Images/42/188705/iphone-11-pro-black-400x460.png", null, "Điện thoại iPhone 11 Pro 64GB", "iOS 13", 27990000.0m, 4, "3 camera 12 MP", "1 Nano SIM & 1 eSIM, Hỗ trợ 4G", "OLED, 5.8\", Super Retina XDR", 5.8f, 64 },
                    { 9, 0, "Samsung", null, null, false, "https://cdn.tgdd.vn/Products/Images/42/226099/samsung-galaxy-z-fold-2-061220-021202-400x460.png", null, "Điện thoại Samsung Galaxy Z Fold2 5G", null, 50000000.0m, 0, null, null, "Chính: Dynamic AMOLED, Phụ: Super AMOLED, Chính 7.59\" & Phụ 6.23\", Full HD+", 0f, 0 },
                    { 7, 4500, "Realme", "Snapdragon 720G 8 nhân", "32 MP", true, "https://cdn.tgdd.vn/Products/Images/42/227689/realme-7-pro-043220-013214-400x460.png", "MicroSD, hỗ trợ tối đa 256 GB", "Điện thoại Realme 7 Pro", "Android 10", 8990000.0m, 8, "Chính 64 MP & Phụ 8 MP, 2 MP, 2 MP", "2 Nano SIM, Hỗ trợ 4G", "Super AMOLED, 6.44\", Full HD+", 6.44f, 128 },
                    { 6, 5000, "Samsung", "Exynos 850 8 nhân", "13 MP", true, "https://cdn.tgdd.vn/Products/Images/42/219314/samsung-galaxy-a21s-055620-045627-400x460.png", "MicroSD, hỗ trợ tối đa 512 GB", "Điện thoại Samsung Galaxy A21s (6GB/64GB)", "Android 10", 5290000.0m, 6, "Chính 48 MP & Phụ 8 MP, 2 MP, 2 MP", "2 Nano SIM, Hỗ trợ 4G", "TFT LCD, 6.5\", HD+", 6.5f, 64 },
                    { 5, 4015, "OPPO", "Snapdragon 720G 8 nhân", "Chính 32 MP & Phụ cảm biến thông minh A.I", true, "https://cdn.tgdd.vn/Products/Images/42/222596/oppo-reno4-260720-040737-400x460.png", "MicroSD, hỗ trợ tối đa 256 GB", "Điện thoại OPPO Reno4", "Android 10", 8490000.0m, 8, "Chính 48 MP & Phụ 8 MP, 2 MP, 2 MP", "2 Nano SIM, Hỗ trợ 4G", "AMOLED, 6.4\", Full HD+", 6.4f, 128 },
                    { 4, 5020, "Xiaomi", "MediaTek Helio G80 8 nhân", "8 MP", true, "https://cdn.tgdd.vn/Products/Images/42/217308/xiaomi-redmi-9-114620-094649-400x460.png", "MicroSD, hỗ trợ tối đa 512 GB", "Điện thoại Xiaomi Redmi 9 (4GB/64GB)", "Android 10", 3790000.0m, 4, "Chính 13 MP & Phụ 8 MP, 5 MP, 2 MP", "2 Nano SIM, Hỗ trợ 4G", "IPS LCD, 6.53\", Full HD+", 6.53f, 64 },
                    { 3, 3110, "iPhone (Apple)", "Apple A13 Bionic 6 nhân", "12 MP", true, "https://cdn.tgdd.vn/Products/Images/42/153856/iphone-11-red-2-400x460-400x460.png", null, "Điện thoại iPhone 11 64GB", "iOS 13", 19990000.0m, 4, "2 camera 12 MP", "1 Nano SIM & 1 eSIM, Hỗ trợ 4G", "IPS LCD, 6.1\", Liquid Retina", 6.1f, 64 },
                    { 2, 5000, "OPPO", "Snapdragon 665 8 nhân", "16 MP", true, "https://cdn.tgdd.vn/Products/Images/42/220654/oppo-a92-tim-400x460-400x460.png", "MicroSD, hỗ trợ tối đa 256 GB", "Điện thoại OPPO A92", "Android 10", 6490000.0m, 8, "Chính 48 MP & Phụ 8 MP, 2 MP, 2 MP", "2 Nano SIM, Hỗ trợ 4G", "TFT LCD, 6.5\", Full HD+", 6.5f, 128 },
                    { 8, 5000, "Vsmart", "Snapdragon 632 8 nhân", "8 MP", true, "https://cdn.tgdd.vn/Products/Images/42/219208/vsmart-joy-3-4gb-den-400x460-400x460.png", "MicroSD, hỗ trợ tối đa 64 GB", "Điện thoại Vsmart Joy 3 (4GB/64GB)", "Android 9 (Pie)", 2990000.0m, 4, "Chính 13 MP & Phụ 8 MP, 2 MP", "2 Nano SIM, Hỗ trợ 4G", "IPS LCD, 6.5\", HD+", 6.5f, 64 },
                    { 17, 3110, "iPhone (Apple)", "Apple A13 Bionic 6 nhân", "12 MP", true, "https://cdn.tgdd.vn/Products/Images/42/210648/iphone-11-256gb-black-400x460.png", null, "Điện thoại iPhone 11 256GB", "iOS 13", 23990000.0m, 4, "2 camera 12 MP", "1 Nano SIM & 1 eSIM, Hỗ trợ 4G", "IPS LCD, 6.1\", Liquid Retina", 6.1f, 256 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

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
                unique: true);
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
