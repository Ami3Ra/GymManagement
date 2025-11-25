using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagementDAL.Entities
{
    internal class Member:GymUser
    {
        // JoinDate == CreatedAt
        public string? Photo { get; set; }

        #region Relationships

        #region Member has Health Record

        public HealthRecored HealthRecored { get; set; }
        #endregion

        #region Member Has Memberships
        public ICollection<Membership> Memberships { get; set; }
        #endregion

        #region Member has MemberSessions
        public ICollection<MemberSession> Sessions { get; set; }
        #endregion
        #endregion
    }
}
