using PhoneStoreBackEnd.Data.Contexts;
using PhoneStoreBackEnd.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneStoreBackEnd.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        #region Properties
        private PhoneStoreContext context;

        private PhoneRepository phoneRepository;
        public PhoneRepository PhoneRepository
        {
            get 
            { 
                if(phoneRepository is null)
                {
                    phoneRepository = new PhoneRepository(context);
                }
                return phoneRepository; 
            }            
        }

        #endregion
        public UnitOfWork(PhoneStoreContext context)
        {
            this.context = context;
        }
        public async Task CompleteAsync()
        {
            await context.SaveChangesAsync();
        }
        
    }
}
