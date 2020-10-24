using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using PhoneStoreBackEnd.Models;
using PhoneStoreBackEnd.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneStoreBackEnd.Data.Repositories
{
    public class PhoneRepository : Repository<Phone>, IPhoneRepository
    {
        public PhoneRepository(IdentityDbContext context) : base(context) 
        {
            
        }

        public async Task<IEnumerable<Phone>> FindByFilterAsync(PhoneFilterResource filter)
        {
            return await FindAsync(x => true);
        }

        public async Task<IEnumerable<Phone>> FindByNameAsync(string name)
        {
            return await FindAsync(x => x.Name == name);
        }
    }
}
