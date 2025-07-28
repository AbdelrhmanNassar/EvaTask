using Eva.Domain._Entities;
using Eva.Domain.DbContexts;
using Eva.Domain.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Eva.Domain.Repositories.Repo
{
    internal class GenericRepo<T> : IGenericRepo<T> where T : BaseEntity
    {
        public GenericRepo(ApplicationDbContext applicationDbContext)
        {
            ApplicationDbContext = applicationDbContext;
        }

        public ApplicationDbContext ApplicationDbContext { get; }

        public void Add(T entity)
        {
            ApplicationDbContext.Set<T>().Add(entity);
        }

        public void Delete(int id)
        {

            var entity = GetById(id);
            entity.IsDeleted = true;
             Update(entity);


        }

        public IEnumerable<T> GetAll()
        {
            if (typeof(T) == typeof(Categories))
                return (IEnumerable<T>)ApplicationDbContext.Category.Where((C) => C.IsDeleted == false).OrderBy(C => C.CategoryOrder).ThenByDescending(C => C.CategoryName);
            else if (typeof(T) == typeof(Product))
                return (IEnumerable<T>)ApplicationDbContext.Products.Where((p) => p.IsDeleted == false).Include(p => p.Category);
            else
              return  ApplicationDbContext.Set<T>().Where((t) => t.IsDeleted == false);

        }

        public T GetById(int id)
        {
            return ApplicationDbContext.Set<T>().Where(T=>T.Id == id && T.IsDeleted == false).FirstOrDefault();
        }

        public void Update(T entity)
        {
            ApplicationDbContext.Set<T>().Update(entity);
        }

    }
}
