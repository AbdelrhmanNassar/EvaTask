using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eva.Domain._Entities;
using Eva.Domain.Repositories.Interfaces;

namespace Eva.Domain
{
    public interface IUnitOfWork : IDisposable
    {
        public IGenericRepo<TEntity> GetRepository<TEntity>() where TEntity : BaseEntity;

        Task<int> CompeleteAsync();
    }
}
