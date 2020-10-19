﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PhoneStoreBackEnd.Data.Contexts;

namespace PhoneStoreBackEnd.Migrations
{
    [DbContext(typeof(PhoneStoreContext))]
    partial class PhoneStoreContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("PhoneStoreBackEnd.Models.Phone", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BatteryCapacity")
                        .HasColumnType("int");

                    b.Property<string>("Brand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CPU")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FrontCamera")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("HasQuickCharge")
                        .HasColumnType("bit");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MemoryCard")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OS")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("money");

                    b.Property<int>("RAM")
                        .HasColumnType("int");

                    b.Property<string>("RearCamera")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SIM")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Screen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("ScreenSize")
                        .HasColumnType("real");

                    b.Property<int>("Storage")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Phones");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BatteryCapacity = 4500,
                            Brand = "Samsung",
                            CPU = "Exynos 990 8 nhân",
                            FrontCamera = "10 MP",
                            HasQuickCharge = true,
                            Image = "https://cdn.tgdd.vn/Products/Images/42/220522/samsung-galaxy-note-20-ultra-vangdong-400x460-400x460.png",
                            MemoryCard = "MicroSD, hỗ trợ tối đa 1 TB",
                            Name = "Điện thoại Samsung Galaxy Note 20 Ultra",
                            OS = "Android 10",
                            Price = 29990000.0m,
                            RAM = 8,
                            RearCamera = "Chính 108 MP & Phụ 12 MP, 12 MP, cảm biến Laser AF",
                            SIM = "2 Nano SIM hoặc 1 Nano SIM + 1 eSIM, Hỗ trợ 4G",
                            Screen = "Dynamic AMOLED 2X, 6.9\", Quad HD+ (2K+)",
                            ScreenSize = 6.9f,
                            Storage = 256
                        },
                        new
                        {
                            Id = 2,
                            BatteryCapacity = 5000,
                            Brand = "OPPO",
                            CPU = "Snapdragon 665 8 nhân",
                            FrontCamera = "16 MP",
                            HasQuickCharge = true,
                            Image = "https://cdn.tgdd.vn/Products/Images/42/220654/oppo-a92-tim-400x460-400x460.png",
                            MemoryCard = "MicroSD, hỗ trợ tối đa 256 GB",
                            Name = "Điện thoại OPPO A92",
                            OS = "Android 10",
                            Price = 6490000.0m,
                            RAM = 8,
                            RearCamera = "Chính 48 MP & Phụ 8 MP, 2 MP, 2 MP",
                            SIM = "2 Nano SIM, Hỗ trợ 4G",
                            Screen = "TFT LCD, 6.5\", Full HD+",
                            ScreenSize = 6.5f,
                            Storage = 128
                        },
                        new
                        {
                            Id = 3,
                            BatteryCapacity = 3110,
                            Brand = "iPhone (Apple)",
                            CPU = "Apple A13 Bionic 6 nhân",
                            FrontCamera = "12 MP",
                            HasQuickCharge = true,
                            Image = "https://cdn.tgdd.vn/Products/Images/42/153856/iphone-11-red-2-400x460-400x460.png",
                            Name = "Điện thoại iPhone 11 64GB",
                            OS = "iOS 13",
                            Price = 19990000.0m,
                            RAM = 4,
                            RearCamera = "2 camera 12 MP",
                            SIM = "1 Nano SIM & 1 eSIM, Hỗ trợ 4G",
                            Screen = "IPS LCD, 6.1\", Liquid Retina",
                            ScreenSize = 6.1f,
                            Storage = 64
                        },
                        new
                        {
                            Id = 4,
                            BatteryCapacity = 5020,
                            Brand = "Xiaomi",
                            CPU = "MediaTek Helio G80 8 nhân",
                            FrontCamera = "8 MP",
                            HasQuickCharge = true,
                            Image = "https://cdn.tgdd.vn/Products/Images/42/217308/xiaomi-redmi-9-114620-094649-400x460.png",
                            MemoryCard = "MicroSD, hỗ trợ tối đa 512 GB",
                            Name = "Điện thoại Xiaomi Redmi 9 (4GB/64GB)",
                            OS = "Android 10",
                            Price = 3790000.0m,
                            RAM = 4,
                            RearCamera = "Chính 13 MP & Phụ 8 MP, 5 MP, 2 MP",
                            SIM = "2 Nano SIM, Hỗ trợ 4G",
                            Screen = "IPS LCD, 6.53\", Full HD+",
                            ScreenSize = 6.53f,
                            Storage = 64
                        },
                        new
                        {
                            Id = 5,
                            BatteryCapacity = 4015,
                            Brand = "OPPO",
                            CPU = "Snapdragon 720G 8 nhân",
                            FrontCamera = "Chính 32 MP & Phụ cảm biến thông minh A.I",
                            HasQuickCharge = true,
                            Image = "https://cdn.tgdd.vn/Products/Images/42/222596/oppo-reno4-260720-040737-400x460.png",
                            MemoryCard = "MicroSD, hỗ trợ tối đa 256 GB",
                            Name = "Điện thoại OPPO Reno4",
                            OS = "Android 10",
                            Price = 8490000.0m,
                            RAM = 8,
                            RearCamera = "Chính 48 MP & Phụ 8 MP, 2 MP, 2 MP",
                            SIM = "2 Nano SIM, Hỗ trợ 4G",
                            Screen = "AMOLED, 6.4\", Full HD+",
                            ScreenSize = 6.4f,
                            Storage = 128
                        },
                        new
                        {
                            Id = 6,
                            BatteryCapacity = 5000,
                            Brand = "Samsung",
                            CPU = "Exynos 850 8 nhân",
                            FrontCamera = "13 MP",
                            HasQuickCharge = true,
                            Image = "https://cdn.tgdd.vn/Products/Images/42/219314/samsung-galaxy-a21s-055620-045627-400x460.png",
                            MemoryCard = "MicroSD, hỗ trợ tối đa 512 GB",
                            Name = "Điện thoại Samsung Galaxy A21s (6GB/64GB)",
                            OS = "Android 10",
                            Price = 5290000.0m,
                            RAM = 6,
                            RearCamera = "Chính 48 MP & Phụ 8 MP, 2 MP, 2 MP",
                            SIM = "2 Nano SIM, Hỗ trợ 4G",
                            Screen = "TFT LCD, 6.5\", HD+",
                            ScreenSize = 6.5f,
                            Storage = 64
                        },
                        new
                        {
                            Id = 7,
                            BatteryCapacity = 4500,
                            Brand = "Realme",
                            CPU = "Snapdragon 720G 8 nhân",
                            FrontCamera = "32 MP",
                            HasQuickCharge = true,
                            Image = "https://cdn.tgdd.vn/Products/Images/42/227689/realme-7-pro-043220-013214-400x460.png",
                            MemoryCard = "MicroSD, hỗ trợ tối đa 256 GB",
                            Name = "Điện thoại Realme 7 Pro",
                            OS = "Android 10",
                            Price = 8990000.0m,
                            RAM = 8,
                            RearCamera = "Chính 64 MP & Phụ 8 MP, 2 MP, 2 MP",
                            SIM = "2 Nano SIM, Hỗ trợ 4G",
                            Screen = "Super AMOLED, 6.44\", Full HD+",
                            ScreenSize = 6.44f,
                            Storage = 128
                        },
                        new
                        {
                            Id = 8,
                            BatteryCapacity = 5000,
                            Brand = "Vsmart",
                            CPU = "Snapdragon 632 8 nhân",
                            FrontCamera = "8 MP",
                            HasQuickCharge = true,
                            Image = "https://cdn.tgdd.vn/Products/Images/42/219208/vsmart-joy-3-4gb-den-400x460-400x460.png",
                            MemoryCard = "MicroSD, hỗ trợ tối đa 64 GB",
                            Name = "Điện thoại Vsmart Joy 3 (4GB/64GB)",
                            OS = "Android 9 (Pie)",
                            Price = 2990000.0m,
                            RAM = 4,
                            RearCamera = "Chính 13 MP & Phụ 8 MP, 2 MP",
                            SIM = "2 Nano SIM, Hỗ trợ 4G",
                            Screen = "IPS LCD, 6.5\", HD+",
                            ScreenSize = 6.5f,
                            Storage = 64
                        },
                        new
                        {
                            Id = 9,
                            BatteryCapacity = 0,
                            Brand = "Samsung",
                            HasQuickCharge = false,
                            Image = "https://cdn.tgdd.vn/Products/Images/42/226099/samsung-galaxy-z-fold-2-061220-021202-400x460.png",
                            Name = "Điện thoại Samsung Galaxy Z Fold2 5G",
                            Price = 50000000.0m,
                            RAM = 0,
                            Screen = "Chính: Dynamic AMOLED, Phụ: Super AMOLED, Chính 7.59\" & Phụ 6.23\", Full HD+",
                            ScreenSize = 0f,
                            Storage = 0
                        },
                        new
                        {
                            Id = 10,
                            BatteryCapacity = 3969,
                            Brand = "iPhone (Apple)",
                            CPU = "Apple A13 Bionic 6 nhân",
                            FrontCamera = "12 MP",
                            HasQuickCharge = true,
                            Image = "https://cdn.tgdd.vn/Products/Images/42/210654/iphone-11-pro-max-512gb-gold-400x460.png",
                            Name = "Điện thoại iPhone 11 Pro Max 512GB",
                            OS = "iOS 13",
                            Price = 38990000.0m,
                            RAM = 4,
                            RearCamera = "3 camera 12 MP",
                            SIM = "1 Nano SIM & 1 eSIM, Hỗ trợ 4G",
                            Screen = "OLED, 6.5\", Super Retina XDR",
                            ScreenSize = 6.5f,
                            Storage = 512
                        },
                        new
                        {
                            Id = 11,
                            BatteryCapacity = 0,
                            Brand = "Samsung",
                            HasQuickCharge = false,
                            Image = "https://cdn.tgdd.vn/Products/Images/42/213022/samsung-galaxy-z-flip-chitiet-2-788x544.png",
                            Name = "Điện thoại Samsung Galaxy Z Flip",
                            Price = 36000000.0m,
                            RAM = 0,
                            Screen = "Chính: Dynamic AMOLED, Phụ: Super AMOLED, 6.7\", Quad HD (2K)",
                            ScreenSize = 0f,
                            Storage = 0
                        },
                        new
                        {
                            Id = 12,
                            BatteryCapacity = 3969,
                            Brand = "iPhone (Apple)",
                            CPU = "Apple A13 Bionic 6 nhân",
                            FrontCamera = "12 MP",
                            HasQuickCharge = true,
                            Image = "https://cdn.tgdd.vn/Products/Images/42/210653/iphone-11-pro-max-256gb-black-400x460.png",
                            Name = "Điện thoại iPhone 11 Pro Max 256GB",
                            OS = "iOS 13",
                            Price = 34990000.0m,
                            RAM = 4,
                            RearCamera = "3 camera 12 MP",
                            SIM = "1 Nano SIM & 1 eSIM, Hỗ trợ 4G",
                            Screen = "OLED, 6.5\", Super Retina XDR",
                            ScreenSize = 6.5f,
                            Storage = 256
                        },
                        new
                        {
                            Id = 13,
                            BatteryCapacity = 4500,
                            Brand = "Samsung",
                            CPU = "Exynos 990 8 nhân",
                            FrontCamera = "10 MP",
                            HasQuickCharge = true,
                            Image = "https://cdn.tgdd.vn/Products/Images/42/225063/samsung-galaxy-note-20-ultra-5g-vangdong-400x460-400x460.png",
                            MemoryCard = "MicroSD, hỗ trợ tối đa 1 TB",
                            Name = "Điện thoại Samsung Galaxy Note 20 Ultra 5G",
                            OS = "Android 10",
                            Price = 32990000.0m,
                            RAM = 12,
                            RearCamera = "Chính 108 MP & Phụ 12 MP, 12 MP, cảm biến Laser AF",
                            SIM = "2 Nano SIM hoặc 1 Nano SIM + 1 eSIM, Hỗ trợ 5G",
                            Screen = "Dynamic AMOLED 2X, 6.9\", Quad HD+ (2K+)",
                            ScreenSize = 6.9f,
                            Storage = 256
                        },
                        new
                        {
                            Id = 14,
                            BatteryCapacity = 3046,
                            Brand = "iPhone (Apple)",
                            CPU = "Apple A13 Bionic 6 nhân",
                            FrontCamera = "12 MP",
                            HasQuickCharge = true,
                            Image = "https://cdn.tgdd.vn/Products/Images/42/210655/iphone-11-pro-256gb-black-400x460.png",
                            Name = "Điện thoại iPhone 11 Pro 256GB",
                            OS = "iOS 13",
                            Price = 31990000.0m,
                            RAM = 4,
                            RearCamera = "3 camera 12 MP",
                            SIM = "1 Nano SIM & 1 eSIM, Hỗ trợ 4G",
                            Screen = "OLED, 5.8\", Super Retina XDR",
                            ScreenSize = 5.8f,
                            Storage = 256
                        },
                        new
                        {
                            Id = 15,
                            BatteryCapacity = 3969,
                            Brand = "iPhone (Apple)",
                            CPU = "Apple A13 Bionic 6 nhân",
                            FrontCamera = "12 MP",
                            HasQuickCharge = true,
                            Image = "https://cdn.tgdd.vn/Products/Images/42/200533/iphone-11-pro-max-black-400x460.png",
                            Name = "Điện thoại iPhone 11 Pro Max 64GB",
                            OS = "iOS 13",
                            Price = 30990000.0m,
                            RAM = 4,
                            RearCamera = "3 camera 12 MP",
                            SIM = "1 Nano SIM & 1 eSIM, Hỗ trợ 4G",
                            Screen = "OLED, 6.5\", Super Retina XDR",
                            ScreenSize = 6.5f,
                            Storage = 64
                        },
                        new
                        {
                            Id = 16,
                            BatteryCapacity = 3046,
                            Brand = "iPhone (Apple)",
                            CPU = "Apple A13 Bionic 6 nhân",
                            FrontCamera = "12 MP",
                            HasQuickCharge = true,
                            Image = "https://cdn.tgdd.vn/Products/Images/42/188705/iphone-11-pro-black-400x460.png",
                            Name = "Điện thoại iPhone 11 Pro 64GB",
                            OS = "iOS 13",
                            Price = 27990000.0m,
                            RAM = 4,
                            RearCamera = "3 camera 12 MP",
                            SIM = "1 Nano SIM & 1 eSIM, Hỗ trợ 4G",
                            Screen = "OLED, 5.8\", Super Retina XDR",
                            ScreenSize = 5.8f,
                            Storage = 64
                        },
                        new
                        {
                            Id = 17,
                            BatteryCapacity = 3110,
                            Brand = "iPhone (Apple)",
                            CPU = "Apple A13 Bionic 6 nhân",
                            FrontCamera = "12 MP",
                            HasQuickCharge = true,
                            Image = "https://cdn.tgdd.vn/Products/Images/42/210648/iphone-11-256gb-black-400x460.png",
                            Name = "Điện thoại iPhone 11 256GB",
                            OS = "iOS 13",
                            Price = 23990000.0m,
                            RAM = 4,
                            RearCamera = "2 camera 12 MP",
                            SIM = "1 Nano SIM & 1 eSIM, Hỗ trợ 4G",
                            Screen = "IPS LCD, 6.1\", Liquid Retina",
                            ScreenSize = 6.1f,
                            Storage = 256
                        });
                });

            modelBuilder.Entity("PhoneStoreBackEnd.Models.AppUser", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("AppUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}