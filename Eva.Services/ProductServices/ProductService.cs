using Eva.Domain;
using Eva.Domain._Entities;
using Eva.Services.ProductServices.Interfaces;

namespace Eva.Services.ProductServices
{
    internal class ProductService : IProductService
    {
        private readonly IUnitOfWork unitOfWork;

        public ProductService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public Task<int> Add(Product entity)
        {


            unitOfWork.GetRepository<Product>().Add(entity);

            return unitOfWork.CompeleteAsync();
        }

        public Task<int> Delete(int id)
        {
            unitOfWork.GetRepository<Product>().Delete(id);
            return unitOfWork.CompeleteAsync();

        }

        public IEnumerable<Product> GetAll()
        {
            return unitOfWork.GetRepository<Product>().GetAll();
        }

        public Product GetById(int id)
        {

            return unitOfWork.GetRepository<Product>().GetById(id);
        }

        public Task<int> Update(Product entity)
        {
            unitOfWork.GetRepository<Product>().Update(entity);
            return unitOfWork.CompeleteAsync();

        }
    }
}