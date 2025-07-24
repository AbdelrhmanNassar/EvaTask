using Eva.Domain._Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eva.Services.CategoryServices
{
    public interface ICategoryServices
    {
        IEnumerable<Categories> GetAll();
        Categories GetById(int id);
        int Add(Categories categories);
        int Update(Categories entity);
        int Delete(int id); 
    }
}
