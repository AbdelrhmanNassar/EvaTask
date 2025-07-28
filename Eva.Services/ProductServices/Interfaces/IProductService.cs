using Eva.Domain._Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eva.Services.ProductServices.Interfaces
{
    //Can be replaced with generic service manager but in other time

    public interface IProductService
    {
        IEnumerable<Product> GetAll();
        Product GetById(int id);
        Task<int> Add(Product entity);
        Task<int> Update(Product entity);
        Task<int> Delete(int id);
    }
}
