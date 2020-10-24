using PhoneStoreBackEnd.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneStoreBackEnd.Data.UnitOfWork
{
    public interface IUnitOfWork
    {
        public PhoneRepository PhoneRepository { get; }
        public Task CompleteAsync();
        
    }
}
