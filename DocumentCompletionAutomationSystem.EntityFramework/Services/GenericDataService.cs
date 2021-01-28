using System.Collections.Generic;
using System.Threading.Tasks;
using DocumentCompletionAutomationSystem.Domain.Models;
using DocumentCompletionAutomationSystem.Domain.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace DocumentCompletionAutomationSystem.EntityFramework.Services
{
    public class GenericDataService<T> : IDataService<T> where T : DomainObject
    {
        private DocumentCompletionAutomationSystemDbContextFactory _contextFactory;
        
        public GenericDataService(DocumentCompletionAutomationSystemDbContextFactory contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            using (DocumentCompletionAutomationSystemDbContext context = _contextFactory.CreateDbContext())
            {
                IEnumerable<T> entities = await context.Set<T>().ToListAsync();

                return entities;
            }
        }

        public async Task<T> Get(int id)
        {
            using (DocumentCompletionAutomationSystemDbContext context = _contextFactory.CreateDbContext())
            {
                T entity = await context.Set<T>().FirstOrDefaultAsync(e => e.Id == id);

                return entity;
            }
        }

        public async Task<T> Create(T entity)
        {
            using (DocumentCompletionAutomationSystemDbContext context = _contextFactory.CreateDbContext())
            {
                EntityEntry<T> createdResult = await context.Set<T>().AddAsync(entity);
                await context.SaveChangesAsync();

                return createdResult.Entity;
            }
        }

        public async Task<T> Update(int id, T entity)
        {
            using (DocumentCompletionAutomationSystemDbContext context = _contextFactory.CreateDbContext())
            {
                entity.Id = id;
                
                context.Set<T>().Update(entity);
                await context.SaveChangesAsync();

                return entity;
            }
        }

        public async Task<bool> Delete(int id)
        {
            using (DocumentCompletionAutomationSystemDbContext context = _contextFactory.CreateDbContext())
            {
                T entity = await context.Set<T>().FirstOrDefaultAsync(e => e.Id == id);
                context.Set<T>().Remove(entity);
                await context.SaveChangesAsync();

                return true;
            }
        }
    }
}