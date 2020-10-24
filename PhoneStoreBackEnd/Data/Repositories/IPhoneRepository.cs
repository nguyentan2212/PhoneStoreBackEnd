using PhoneStoreBackEnd.Models;
using PhoneStoreBackEnd.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneStoreBackEnd.Data.Repositories
{
    public interface IPhoneRepository: IRepository<Phone>
    {
        public Task<IEnumerable<Phone>> FindByNameAsync(string name);
        public Task<IEnumerable<Phone>> FindByFilterAsync(PhoneFilterResource filter);
    }
}
