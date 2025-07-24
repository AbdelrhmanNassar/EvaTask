using Eva.Domain._Entities;

namespace Eva.Domain.Repositories.Interfaces
{
    public interface ICategoryRepository
    {
        IEnumerable<Categories> GetAll();
        Categories GetById(int id);
        int Add(Categories categories);
        int Update(Categories entity);
        int Delete(int id);

    }
}
