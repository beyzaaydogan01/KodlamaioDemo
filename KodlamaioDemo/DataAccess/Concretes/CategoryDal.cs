using KodlamaioDemo.DataAccess.Abstracts;
using KodlamaioDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioDemo.DataAccess.Concretes
{
    public class CategoryDal : ICategoryDal
    {
        List<Category> _categories;
        public CategoryDal()
        {

            Category category1 = new Category();
            category1.Id = 1;
            category1.CategoryName = "Programlama";

            Category category2 = new Category();
            category2.Id = 2;
            category2.CategoryName = "Veritabanı";


            _categories = new List<Category> { category1, category2 };
        }

        public void Add(Category category)
        {
            _categories.Add(category);
        }
        public void Update(Category category)
        {
            Category categoryToUpdate = _categories.FirstOrDefault(c => c.Id == category.Id);
            if (categoryToUpdate != null)
            {
                categoryToUpdate.CategoryName = category.CategoryName;
            }
        }
        public void Delete(Category category)
        {
            Category categoryToDelete = _categories.FirstOrDefault(c=>  c.Id == category.Id);
            if (categoryToDelete != null)
            {
                _categories.Remove(categoryToDelete);
            }
        }

        public List<Category> GetAll()
        {
            return _categories;
        }

        
    }
}
