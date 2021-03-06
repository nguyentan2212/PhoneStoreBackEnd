﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace PhoneStoreBackEnd.Data.Repositories
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected IdentityDbContext context;
        protected DbSet<TEntity> DbSetEntity;
        public Repository(IdentityDbContext context)
        {
            this.context = context;
            DbSetEntity = this.context.Set<TEntity>();
        }
        public async Task<TEntity> GetAsync(int id)
        {
            return await DbSetEntity.FindAsync(id);
        }
        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await DbSetEntity.ToListAsync();
        }
        public async Task<IEnumerable<TEntity>> FindAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await DbSetEntity.Where(predicate).ToListAsync();
        }
        public async Task AddAsync(TEntity entity)
        {
            await DbSetEntity.AddAsync(entity);
        }
        public async Task AddRangeAsync(IEnumerable<TEntity> entities)
        {
            await DbSetEntity.AddRangeAsync(entities);
        }
        public void Remove(TEntity entity)
        {
            DbSetEntity.Remove(entity);
        }
        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            DbSetEntity.RemoveRange(entities);
        }
        public async Task<TEntity> SingleOrDefaultAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await DbSetEntity.SingleOrDefaultAsync(predicate);
        }
        public void Update(TEntity entity)
        {
            DbSetEntity.Update(entity);
        }
    }
}
