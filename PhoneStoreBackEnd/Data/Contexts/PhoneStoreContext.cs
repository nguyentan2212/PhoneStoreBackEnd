using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using PhoneStoreBackEnd.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneStoreBackEnd.Data.Contexts
{
    public class PhoneStoreContext : IdentityDbContext
    {
        public DbSet<Phone> Phones { get; set; }
        public DbSet<AppUser> Customers { get; set; }

        public PhoneStoreContext(DbContextOptions<PhoneStoreContext> options):base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Phone>().Property(p => p.Price).HasColumnType("money");       

            string jsonConnect = @"C:\Users\ASUS\source\repos\PhoneStoreBackEnd\PhoneStoreBackEnd\PhonesUpdate.Json";
            string phonesJson = File.ReadAllText(jsonConnect);
            List<Phone> phones = JsonConvert.DeserializeObject<List<Phone>>(phonesJson);
            builder.Entity<Phone>().HasData(phones);
            
        }
    }
}
