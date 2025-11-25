using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GymManagementDAL.Entities;

namespace GymManagementDAL.Repositories.Interfaces
{
    internal interface ITrainerRepository
    {
        // Flat Objects Deaaling
        //GetAll
        IEnumerable<Trainer> GetAllTrainers();
        //GetById
        Trainer? GetTrainerById(int id);
        //Add
        int Add(Trainer trainer);
        //Update
        int Update(Trainer trainer);
        //Delete
        int Remove(int id);
    }
}
