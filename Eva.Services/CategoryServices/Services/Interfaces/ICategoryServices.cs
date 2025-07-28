using Eva.Domain._Entities;

namespace Eva.Services.CategoryServices.Services.Interfaces
{
    //Can be replaced with generic service manager but in other time
    public interface ICategoryServices
    {
        IEnumerable<Categories> GetAll();
        Categories GetById(int id);
        Task<int> Add(Categories categories);
        Task<int> Update(Categories entity);
        Task<int> Delete(int id);
    }
}
