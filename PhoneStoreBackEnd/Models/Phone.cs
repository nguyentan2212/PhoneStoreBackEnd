using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneStoreBackEnd.Models
{
    public class Phone
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }

        public string Brand { get; set; }

        public string Screen { get; set; }
        public float ScreenSize { get; set; }
        public string OS { get; set; }
        public string RearCamera { get; set; }
        public string FrontCamera { get; set; }
        public string CPU { get; set; }
        public int RAM { get; set; }
        public int Storage { get; set; }
        public string MemoryCard { get; set; }
        public string SIM { get; set; }
        public int BatteryCapacity { get; set; }
        public bool HasQuickCharge { get; set; }
    }
}
