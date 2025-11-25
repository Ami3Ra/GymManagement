using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagementDAL.Entities
{
    internal class Session:BaseEntity
    {
        public string Description { get; set; }
        public int Capacity { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        #region Relationships

        #region Trainer-Session
        public int TrainerId { get; set; }
        public Trainer Trainer { get; set; }
        #endregion

        #region Category-Session

        public int CategoryId { get; set; }
        public Category Category { get; set; }
        #endregion

        #region Session has MemberSessions
        public ICollection<MemberSession> MemberSessions { get; set; }
        #endregion

        #endregion
    }
}
