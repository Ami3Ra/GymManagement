using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GymManagementDAL.Data.Contexts;
using GymManagementDAL.Entities;
using GymManagementDAL.Repositories.Interfaces;

namespace GymManagementDAL.Repositories.Implementation
{
    internal class PlanRepository : IPlanRepository
    {
        private readonly GymDbContext _dbContext = new GymDbContext();
        public IEnumerable<Plan> GetAllPlans()
            => _dbContext.plans.ToList();

        public Plan? GetPlanById(int id)
            => _dbContext.plans.Find(id);

        //public int Add(Plan plan)
        //{
        //    _dbContext.plans.Add(plan);
        //    return _dbContext.SaveChanges();
        //}

        public int Update(Plan plan)
        {
            _dbContext.plans.Update(plan);
            return _dbContext.SaveChanges();
        }

        //public int Remove(int id)
        //{
        //    var plan = _dbContext.plans.Find(id);
        //    if (plan is null)  return 0;

        //    _dbContext.plans.Remove(plan);
        //    return _dbContext.SaveChanges();
        //}

    }
}
