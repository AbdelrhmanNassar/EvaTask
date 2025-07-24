using Eva.Domain._Entities;
using Eva.Domain.Repositories.Interfaces;

namespace Eva.Services.CategoryServices.Services.Interfaces
{
    internal class CategoryService : ICategoryServices
    {
        private readonly ICategoryRepository categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }

        public int Add(Categories categories)
        {
            return categoryRepository.Add(categories);
        }

        public int Delete(int id)
        {
            return categoryRepository.Delete(id);

        }

        public IEnumerable<Categories> GetAll()
        {
            return categoryRepository.GetAll();
        }

        public Categories GetById(int id)
        {

            return categoryRepository.GetById(id);
        }

        public int Update(Categories entity)
        {
            return categoryRepository.Update(entity);
        }
    }
}