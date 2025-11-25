using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GymManagementDAL.Entities.Enums;

namespace GymManagementDAL.Entities
{
    internal class Trainer:GymUser
    {
        // HireDate == CreatedAt
        public Specialities specialities { get; set; }

        #region Relationships

        #region Trainer-Session
        public ICollection<Session> Sessions { get; set; }
        #endregion


        #endregion
    }
}
