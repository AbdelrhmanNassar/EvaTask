using Eva.Domain._Entities;
using Eva.Domain.DbContexts;
using Eva.Domain.Repositories.Interfaces;
using Eva.Domain.Repositories.Repo;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eva.Domain
{
    internal class unitOfWork : IUnitOfWork
    {

        private readonly ApplicationDbContext _context;
        private ConcurrentDictionary<string, object> _repositories;
        public unitOfWork(ApplicationDbContext context)
        {
            _context = context;
            _repositories = new ConcurrentDictionary<string, object>();
        }


        public IGenericRepo<TEntity> GetRepository<TEntity>()
            where TEntity : BaseEntity
        {
            //Need to check about generic repo life time inside Unit of work

            return (IGenericRepo<TEntity>)_repositories.GetOrAdd(typeof(TEntity).Name, new GenericRepo<TEntity>(_context)) ;


        }
        public async Task<int> CompeleteAsync() => await _context.SaveChangesAsync();
        public async void Dispose() => await _context.DisposeAsync();
    }
}
