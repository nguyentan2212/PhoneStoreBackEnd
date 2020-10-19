using Microsoft.EntityFrameworkCore.Migrations;

namespace PhoneStoreBackEnd.Migrations
{
    public partial class UpdatePhoneClass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.AddColumn<int>(
                name: "BatteryCapacity",
                table: "Phones",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Brand",
                table: "Phones",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CPU",
                table: "Phones",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FrontCamera",
                table: "Phones",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "HasQuickCharge",
                table: "Phones",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "MemoryCard",
                table: "Phones",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OS",
                table: "Phones",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RAM",
                table: "Phones",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "RearCamera",
                table: "Phones",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SIM",
                table: "Phones",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Screen",
                table: "Phones",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "ScreenSize",
                table: "Phones",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<int>(
                name: "Storage",
                table: "Phones",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BatteryCapacity", "Brand", "CPU", "FrontCamera", "HasQuickCharge", "Image", "MemoryCard", "Name", "OS", "RAM", "RearCamera", "SIM", "Screen", "ScreenSize", "Storage" },
                values: new object[] { 4500, "Samsung", "Exynos 990 8 nhân", "10 MP", true, "https://cdn.tgdd.vn/Products/Images/42/220522/samsung-galaxy-note-20-ultra-vangdong-400x460-400x460.png", "MicroSD, hỗ trợ tối đa 1 TB", "Điện thoại Samsung Galaxy Note 20 Ultra", "Android 10", 8, "Chính 108 MP & Phụ 12 MP, 12 MP, cảm biến Laser AF", "2 Nano SIM hoặc 1 Nano SIM + 1 eSIM, Hỗ trợ 4G", "Dynamic AMOLED 2X, 6.9\", Quad HD+ (2K+)", 6.9f, 256 });

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BatteryCapacity", "Brand", "CPU", "FrontCamera", "HasQuickCharge", "Image", "MemoryCard", "Name", "OS", "Price", "RAM", "RearCamera", "SIM", "Screen", "ScreenSize", "Storage" },
                values: new object[] { 5000, "OPPO", "Snapdragon 665 8 nhân", "16 MP", true, "https://cdn.tgdd.vn/Products/Images/42/220654/oppo-a92-tim-400x460-400x460.png", "MicroSD, hỗ trợ tối đa 256 GB", "Điện thoại OPPO A92", "Android 10", 6490000.0m, 8, "Chính 48 MP & Phụ 8 MP, 2 MP, 2 MP", "2 Nano SIM, Hỗ trợ 4G", "TFT LCD, 6.5\", Full HD+", 6.5f, 128 });

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BatteryCapacity", "Brand", "CPU", "FrontCamera", "HasQuickCharge", "Image", "Name", "OS", "RAM", "RearCamera", "SIM", "Screen", "ScreenSize", "Storage" },
                values: new object[] { 3110, "iPhone (Apple)", "Apple A13 Bionic 6 nhân", "12 MP", true, "https://cdn.tgdd.vn/Products/Images/42/153856/iphone-11-red-2-400x460-400x460.png", "Điện thoại iPhone 11 64GB", "iOS 13", 4, "2 camera 12 MP", "1 Nano SIM & 1 eSIM, Hỗ trợ 4G", "IPS LCD, 6.1\", Liquid Retina", 6.1f, 64 });

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BatteryCapacity", "Brand", "CPU", "FrontCamera", "HasQuickCharge", "Image", "MemoryCard", "Name", "OS", "Price", "RAM", "RearCamera", "SIM", "Screen", "ScreenSize", "Storage" },
                values: new object[] { 5020, "Xiaomi", "MediaTek Helio G80 8 nhân", "8 MP", true, "https://cdn.tgdd.vn/Products/Images/42/217308/xiaomi-redmi-9-114620-094649-400x460.png", "MicroSD, hỗ trợ tối đa 512 GB", "Điện thoại Xiaomi Redmi 9 (4GB/64GB)", "Android 10", 3790000.0m, 4, "Chính 13 MP & Phụ 8 MP, 5 MP, 2 MP", "2 Nano SIM, Hỗ trợ 4G", "IPS LCD, 6.53\", Full HD+", 6.53f, 64 });

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BatteryCapacity", "Brand", "CPU", "FrontCamera", "HasQuickCharge", "Image", "MemoryCard", "Name", "OS", "Price", "RAM", "RearCamera", "SIM", "Screen", "ScreenSize", "Storage" },
                values: new object[] { 4015, "OPPO", "Snapdragon 720G 8 nhân", "Chính 32 MP & Phụ cảm biến thông minh A.I", true, "https://cdn.tgdd.vn/Products/Images/42/222596/oppo-reno4-260720-040737-400x460.png", "MicroSD, hỗ trợ tối đa 256 GB", "Điện thoại OPPO Reno4", "Android 10", 8490000.0m, 8, "Chính 48 MP & Phụ 8 MP, 2 MP, 2 MP", "2 Nano SIM, Hỗ trợ 4G", "AMOLED, 6.4\", Full HD+", 6.4f, 128 });

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BatteryCapacity", "Brand", "CPU", "FrontCamera", "HasQuickCharge", "Image", "MemoryCard", "Name", "OS", "Price", "RAM", "RearCamera", "SIM", "Screen", "ScreenSize", "Storage" },
                values: new object[] { 5000, "Samsung", "Exynos 850 8 nhân", "13 MP", true, "https://cdn.tgdd.vn/Products/Images/42/219314/samsung-galaxy-a21s-055620-045627-400x460.png", "MicroSD, hỗ trợ tối đa 512 GB", "Điện thoại Samsung Galaxy A21s (6GB/64GB)", "Android 10", 5290000.0m, 6, "Chính 48 MP & Phụ 8 MP, 2 MP, 2 MP", "2 Nano SIM, Hỗ trợ 4G", "TFT LCD, 6.5\", HD+", 6.5f, 64 });

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BatteryCapacity", "Brand", "CPU", "FrontCamera", "HasQuickCharge", "Image", "MemoryCard", "Name", "OS", "Price", "RAM", "RearCamera", "SIM", "Screen", "ScreenSize", "Storage" },
                values: new object[] { 4500, "Realme", "Snapdragon 720G 8 nhân", "32 MP", true, "https://cdn.tgdd.vn/Products/Images/42/227689/realme-7-pro-043220-013214-400x460.png", "MicroSD, hỗ trợ tối đa 256 GB", "Điện thoại Realme 7 Pro", "Android 10", 8990000.0m, 8, "Chính 64 MP & Phụ 8 MP, 2 MP, 2 MP", "2 Nano SIM, Hỗ trợ 4G", "Super AMOLED, 6.44\", Full HD+", 6.44f, 128 });

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BatteryCapacity", "Brand", "CPU", "FrontCamera", "HasQuickCharge", "Image", "MemoryCard", "Name", "OS", "Price", "RAM", "RearCamera", "SIM", "Screen", "ScreenSize", "Storage" },
                values: new object[] { 5000, "Vsmart", "Snapdragon 632 8 nhân", "8 MP", true, "https://cdn.tgdd.vn/Products/Images/42/219208/vsmart-joy-3-4gb-den-400x460-400x460.png", "MicroSD, hỗ trợ tối đa 64 GB", "Điện thoại Vsmart Joy 3 (4GB/64GB)", "Android 9 (Pie)", 2990000.0m, 4, "Chính 13 MP & Phụ 8 MP, 2 MP", "2 Nano SIM, Hỗ trợ 4G", "IPS LCD, 6.5\", HD+", 6.5f, 64 });

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Brand", "Image", "Name", "Screen" },
                values: new object[] { "Samsung", "https://cdn.tgdd.vn/Products/Images/42/226099/samsung-galaxy-z-fold-2-061220-021202-400x460.png", "Điện thoại Samsung Galaxy Z Fold2 5G", "Chính: Dynamic AMOLED, Phụ: Super AMOLED, Chính 7.59\" & Phụ 6.23\", Full HD+" });

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "BatteryCapacity", "Brand", "CPU", "FrontCamera", "HasQuickCharge", "Image", "Name", "OS", "RAM", "RearCamera", "SIM", "Screen", "ScreenSize", "Storage" },
                values: new object[] { 3969, "iPhone (Apple)", "Apple A13 Bionic 6 nhân", "12 MP", true, "https://cdn.tgdd.vn/Products/Images/42/210654/iphone-11-pro-max-512gb-gold-400x460.png", "Điện thoại iPhone 11 Pro Max 512GB", "iOS 13", 4, "3 camera 12 MP", "1 Nano SIM & 1 eSIM, Hỗ trợ 4G", "OLED, 6.5\", Super Retina XDR", 6.5f, 512 });

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Brand", "Image", "Name", "Screen" },
                values: new object[] { "Samsung", "https://cdn.tgdd.vn/Products/Images/42/213022/samsung-galaxy-z-flip-chitiet-2-788x544.png", "Điện thoại Samsung Galaxy Z Flip", "Chính: Dynamic AMOLED, Phụ: Super AMOLED, 6.7\", Quad HD (2K)" });

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "BatteryCapacity", "Brand", "CPU", "FrontCamera", "HasQuickCharge", "Image", "Name", "OS", "RAM", "RearCamera", "SIM", "Screen", "ScreenSize", "Storage" },
                values: new object[] { 3969, "iPhone (Apple)", "Apple A13 Bionic 6 nhân", "12 MP", true, "https://cdn.tgdd.vn/Products/Images/42/210653/iphone-11-pro-max-256gb-black-400x460.png", "Điện thoại iPhone 11 Pro Max 256GB", "iOS 13", 4, "3 camera 12 MP", "1 Nano SIM & 1 eSIM, Hỗ trợ 4G", "OLED, 6.5\", Super Retina XDR", 6.5f, 256 });

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "BatteryCapacity", "Brand", "CPU", "FrontCamera", "HasQuickCharge", "Image", "MemoryCard", "Name", "OS", "RAM", "RearCamera", "SIM", "Screen", "ScreenSize", "Storage" },
                values: new object[] { 4500, "Samsung", "Exynos 990 8 nhân", "10 MP", true, "https://cdn.tgdd.vn/Products/Images/42/225063/samsung-galaxy-note-20-ultra-5g-vangdong-400x460-400x460.png", "MicroSD, hỗ trợ tối đa 1 TB", "Điện thoại Samsung Galaxy Note 20 Ultra 5G", "Android 10", 12, "Chính 108 MP & Phụ 12 MP, 12 MP, cảm biến Laser AF", "2 Nano SIM hoặc 1 Nano SIM + 1 eSIM, Hỗ trợ 5G", "Dynamic AMOLED 2X, 6.9\", Quad HD+ (2K+)", 6.9f, 256 });

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "BatteryCapacity", "Brand", "CPU", "FrontCamera", "HasQuickCharge", "Image", "Name", "OS", "RAM", "RearCamera", "SIM", "Screen", "ScreenSize", "Storage" },
                values: new object[] { 3046, "iPhone (Apple)", "Apple A13 Bionic 6 nhân", "12 MP", true, "https://cdn.tgdd.vn/Products/Images/42/210655/iphone-11-pro-256gb-black-400x460.png", "Điện thoại iPhone 11 Pro 256GB", "iOS 13", 4, "3 camera 12 MP", "1 Nano SIM & 1 eSIM, Hỗ trợ 4G", "OLED, 5.8\", Super Retina XDR", 5.8f, 256 });

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "BatteryCapacity", "Brand", "CPU", "FrontCamera", "HasQuickCharge", "Image", "Name", "OS", "RAM", "RearCamera", "SIM", "Screen", "ScreenSize", "Storage" },
                values: new object[] { 3969, "iPhone (Apple)", "Apple A13 Bionic 6 nhân", "12 MP", true, "https://cdn.tgdd.vn/Products/Images/42/200533/iphone-11-pro-max-black-400x460.png", "Điện thoại iPhone 11 Pro Max 64GB", "iOS 13", 4, "3 camera 12 MP", "1 Nano SIM & 1 eSIM, Hỗ trợ 4G", "OLED, 6.5\", Super Retina XDR", 6.5f, 64 });

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "BatteryCapacity", "Brand", "CPU", "FrontCamera", "HasQuickCharge", "Image", "Name", "OS", "RAM", "RearCamera", "SIM", "Screen", "ScreenSize", "Storage" },
                values: new object[] { 3046, "iPhone (Apple)", "Apple A13 Bionic 6 nhân", "12 MP", true, "https://cdn.tgdd.vn/Products/Images/42/188705/iphone-11-pro-black-400x460.png", "Điện thoại iPhone 11 Pro 64GB", "iOS 13", 4, "3 camera 12 MP", "1 Nano SIM & 1 eSIM, Hỗ trợ 4G", "OLED, 5.8\", Super Retina XDR", 5.8f, 64 });

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "BatteryCapacity", "Brand", "CPU", "FrontCamera", "HasQuickCharge", "Image", "Name", "OS", "RAM", "RearCamera", "SIM", "Screen", "ScreenSize", "Storage" },
                values: new object[] { 3110, "iPhone (Apple)", "Apple A13 Bionic 6 nhân", "12 MP", true, "https://cdn.tgdd.vn/Products/Images/42/210648/iphone-11-256gb-black-400x460.png", "Điện thoại iPhone 11 256GB", "iOS 13", 4, "2 camera 12 MP", "1 Nano SIM & 1 eSIM, Hỗ trợ 4G", "IPS LCD, 6.1\", Liquid Retina", 6.1f, 256 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BatteryCapacity",
                table: "Phones");

            migrationBuilder.DropColumn(
                name: "Brand",
                table: "Phones");

            migrationBuilder.DropColumn(
                name: "CPU",
                table: "Phones");

            migrationBuilder.DropColumn(
                name: "FrontCamera",
                table: "Phones");

            migrationBuilder.DropColumn(
                name: "HasQuickCharge",
                table: "Phones");

            migrationBuilder.DropColumn(
                name: "MemoryCard",
                table: "Phones");

            migrationBuilder.DropColumn(
                name: "OS",
                table: "Phones");

            migrationBuilder.DropColumn(
                name: "RAM",
                table: "Phones");

            migrationBuilder.DropColumn(
                name: "RearCamera",
                table: "Phones");

            migrationBuilder.DropColumn(
                name: "SIM",
                table: "Phones");

            migrationBuilder.DropColumn(
                name: "Screen",
                table: "Phones");

            migrationBuilder.DropColumn(
                name: "ScreenSize",
                table: "Phones");

            migrationBuilder.DropColumn(
                name: "Storage",
                table: "Phones");

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Image", "Name" },
                values: new object[] { "https://cdn.tgdd.vn/Products/Images/42/220522/Feature/samsung-galaxy-note-20-ultra-spec-fixed-720x333.jpg", "Samsung Galaxy Note 20 Ultra" });

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Image", "Name", "Price" },
                values: new object[] { "https://cdn.tgdd.vn/Products/Images/42/229056/oppo-a93-230520-060532-200x200.jpg", "OPPO A93", 7490000.0m });

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Image", "Name" },
                values: new object[] { "https://cdn.tgdd.vn/Products/Images/42/153856/iphone-11-red-400x400.jpg", "iPhone 11 64GB" });

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Image", "Name", "Price" },
                values: new object[] { "https://cdn.tgdd.vn/Products/Images/42/217308/xiaomi-redmi-9-114620-094644-400x400.jpg", "Xiaomi Redmi 9 (4GB/64GB)", 3590000.0m });

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Image", "Name", "Price" },
                values: new object[] { "https://cdn.tgdd.vn/Products/Images/42/220654/Feature/1602154414868-720x333.png", "OPPO A92", 5940000.0m });

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Image", "Name", "Price" },
                values: new object[] { "https://cdn.tgdd.vn/Products/Images/42/219314/samsung-galaxy-a21s-055620-045659-400x400.jpg", "Samsung Galaxy A21s (6GB/64GB)", 4830000.0m });

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Image", "Name", "Price" },
                values: new object[] { "https://cdn.tgdd.vn/Products/Images/42/227689/realme-7-pro-043220-013244-400x400.jpg", "Realme 7 Pro", 8490000.0m });

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Image", "Name", "Price" },
                values: new object[] { "https://cdn.tgdd.vn/Products/Images/42/228888/vsmart-joy-4-4gb-64gb-171020-021003-400x400.jpg", "Vsmart Joy 4 (4GB/64GB)", 3590000.0m });

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Image", "Name" },
                values: new object[] { "https://cdn.tgdd.vn/Products/Images/42/226099/samsung-galaxy-z-fold-2-061220-021232-200x200.jpg", "Samsung Galaxy Z Fold2 5G" });

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Image", "Name" },
                values: new object[] { "https://cdn.tgdd.vn/Products/Images/42/210654/iphone-11-pro-max-512gb-gold-400x400.jpg", "iPhone 11 Pro Max 512GB" });

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Image", "Name" },
                values: new object[] { "https://cdn.tgdd.vn/Products/Images/42/213022/samsung-galaxy-z-flip-den-600x600-400x400.jpg", "Samsung Galaxy Z Flip" });

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Image", "Name" },
                values: new object[] { "https://cdn.tgdd.vn/Products/Images/42/210653/iphone-11-pro-max-256gb-black-400x400.jpg", "iPhone 11 Pro Max 256GB" });

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Image", "Name" },
                values: new object[] { "https://cdn.tgdd.vn/Products/Images/42/225063/samsung-galaxy-note-20-ultra-5g-063420-123447-400x400.jpg", "Samsung Galaxy Note 20 Ultra 5G" });

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Image", "Name" },
                values: new object[] { "https://cdn.tgdd.vn/Products/Images/42/210655/iphone-11-pro-256gb-black-400x400.jpg", "iPhone 11 Pro 256GB" });

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Image", "Name" },
                values: new object[] { "https://cdn.tgdd.vn/Products/Images/42/200533/iphone-11-pro-max-green-400x400.jpg", "iPhone 11 Pro Max 64GB" });

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Image", "Name" },
                values: new object[] { "https://cdn.tgdd.vn/Products/Images/42/188705/iphone-11-pro-black-400x400.jpg", "iPhone 11 Pro 64GB" });

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Image", "Name" },
                values: new object[] { "https://cdn.tgdd.vn/Products/Images/42/210648/iphone-11-256gb-black-400x400.jpg", "iPhone 11 256GB" });

            migrationBuilder.InsertData(
                table: "Phones",
                columns: new[] { "Id", "Image", "Name", "Price" },
                values: new object[,]
                {
                    { 27, "https://cdn.tgdd.vn/Products/Images/42/190323/iphone-xs-gold-600x600-2-400x400.jpg", "iPhone Xs 64GB", 17990000.0m },
                    { 26, "https://cdn.tgdd.vn/Products/Images/42/206176/samsung-galaxy-note-10-plus-171220-101247-400x400.jpg", "Samsung Galaxy Note 10+", 15990000.0m },
                    { 25, "https://cdn.tgdd.vn/Products/Images/42/223290/vivo-x50-pro-155920-035955-200x200.jpg", "Vivo X50 Pro", 18990000.0m },
                    { 24, "https://cdn.tgdd.vn/Products/Images/42/217935/samsung-galaxy-s20-600x600-hong-400x400.jpg", "Samsung Galaxy S20", 21490000.0m },
                    { 23, "https://cdn.tgdd.vn/Products/Images/42/210644/iphone-11-128gb-green-400x400.jpg", "iPhone 11 128GB", 21990000.0m },
                    { 22, "https://cdn.tgdd.vn/Products/Images/42/198150/oppo-find-x2-blue-600x600-400x400.jpg", "OPPO Find X2", 19990000.0m },
                    { 21, "https://cdn.tgdd.vn/Products/Images/42/214638/oneplus-8-pro-1-200x200.jpg", "OnePlus 8 Pro 5G", 22990000.0m },
                    { 20, "https://cdn.tgdd.vn/Products/Images/42/215773/huawei-p40-pro-600x600-3-400x400.jpg", "Huawei P40 Pro (Nền tảng Huawei Mobile Service)", 21990000.0m },
                    { 19, "https://cdn.tgdd.vn/Products/Images/42/218355/samsung-galaxy-note-20-062220-122200-400x400.jpg", "Samsung Galaxy Note 20", 23990000.0m },
                    { 28, "https://cdn.tgdd.vn/Products/Images/42/222631/iphone-se-256gb-2020-261920-101916-200x200.jpg", "iPhone SE 256GB (2020)", 17990000.0m },
                    { 18, "https://cdn.tgdd.vn/Products/Images/42/217936/samsung-galaxy-s20-plus-600x600-fix-400x400.jpg", "Samsung Galaxy S20+", 16990000.0m }
                });
        }
    }
}
