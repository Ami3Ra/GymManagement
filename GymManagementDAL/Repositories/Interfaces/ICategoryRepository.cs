using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GymManagementDAL.Entities;

namespace GymManagementDAL.Repositories.Interfaces
{
    internal interface ICategoryRepository
    {
        //GetAll
        IEnumerable<Category> GetAllCategories();
        //GetById
        Category? GetCategoryById(int id);
        //Add
        int Add(Category category);
        //Update
        int Update(Category category);
        //Delete
        int Remove(int id);
    }
}
