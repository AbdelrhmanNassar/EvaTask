using Eva.Domain;
using Eva.Domain._Entities;
using Eva.Services.CategoryServices.Services.Interfaces;

namespace Eva.Services.CategoryServices.Services
{
    internal class CategoryService : ICategoryServices
    {

        public CategoryService(IUnitOfWork unitOfWork)
        {
            UnitOfWork = unitOfWork;
        }

        public IUnitOfWork UnitOfWork { get; }

        public Task<int> Add(Categories categories)
        {


             UnitOfWork.GetRepository<Categories>().Add(categories);

            return UnitOfWork.CompeleteAsync();
        }

        public Task<int> Delete(int id)
        {
             UnitOfWork.GetRepository<Categories>().Delete(id);
            return UnitOfWork.CompeleteAsync();

        }

        public IEnumerable<Categories> GetAll()
        {
            return UnitOfWork.GetRepository<Categories>().GetAll();
        }

        public Categories GetById(int id)
        {

            return UnitOfWork.GetRepository<Categories>().GetById(id);
        }

        public Task<int> Update(Categories entity)
        {
             UnitOfWork.GetRepository<Categories>().Update(entity);
            return UnitOfWork.CompeleteAsync();

        }
    }
}