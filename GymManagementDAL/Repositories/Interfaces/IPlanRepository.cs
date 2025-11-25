using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GymManagementDAL.Entities;

namespace GymManagementDAL.Repositories.Interfaces
{
    internal interface IPlanRepository
    {
        //GetAll
        IEnumerable<Plan> GetAllPlans();
        //GetById
        Plan? GetPlanById(int id);
        //Add
        //int Add(Plan plan);
        //Update
        int Update(Plan plan);
        //Delete
        //int Remove(int  id);
    }
}
