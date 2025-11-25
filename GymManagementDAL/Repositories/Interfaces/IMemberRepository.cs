using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GymManagementDAL.Entities;

namespace GymManagementDAL.Repositories.Interfaces
{
    internal interface IMemberRepository
    {
        // Flat Objects Deaaling
        //GETALL
        IEnumerable<Member> GetAllMembers();
        //GETBYID
        Member? GetMemberById(int id);
        //ADD
        int Add(Member member);
        //UPDATE
        int Update(Member member);
        //DELETE
        int Remove(int  id);
    }
}
