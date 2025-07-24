using Eva.Domain._Entities;
using Eva.Domain.DbContexts;
using Eva.Domain.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eva.Domain.Repositories.Repo
{
    internal class CategoryRepository : ICategoryRepository
    {
        private CategoryDbContext categoryDbContext;

        public CategoryRepository(CategoryDbContext categoryDbContext)
        {
            this.categoryDbContext = categoryDbContext;
        }
        public int Add(Categories categories)
        {
            categoryDbContext.Category.Add(categories);
            return categoryDbContext.SaveChanges();

        }

        public int Delete(int id)
        {

            var entity = GetById(id);
            entity.IsDeleted = true;
            return Update(entity);
        }

        public IEnumerable<Categories> GetAll()
        {
            return categoryDbContext.Category.Where((C) => C.IsDeleted == false);
        }

        public Categories GetById(int id)
        {
            return categoryDbContext.Category.Where(c => c.CategoryId == id && !c.IsDeleted).FirstOrDefault();
        }

        public int Update(Categories entity)
        {

            categoryDbContext.Category.Update(entity);
            return categoryDbContext.SaveChanges();

        }


    }
}
