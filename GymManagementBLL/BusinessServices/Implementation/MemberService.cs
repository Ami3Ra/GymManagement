using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GymManagementBLL.BusinessServices.Interfaces;
using GymManagementBLL.View_Models;
using GymManagementDAL.Entities;
using GymManagementDAL.Repositories.Interfaces;

namespace GymManagementBLL.BusinessServices.Implementation
{
    internal class MemberService : IMemberService
    {
        private readonly IGenericRepository<Member> _memberRepository;

        // Ask CLR To inject object from class Implement interface IGeneric Repository
        public MemberService(IGenericRepository<Member> memberRepository)
        {
            _memberRepository = memberRepository;
        }
        public IEnumerable<MemberViewModel> GetAllMembers()
        {
            var members = _memberRepository.GetAll();
            if (members is null || !members.Any()) return [];

            #region Manual Mapping First Way
            //var listOfMembersViewModel = new List<MemberViewModel>();

            //foreach(var member in members) 
            //{
            //    var memberViewModel = new MemberViewModel
            //    {
            //        Id = member.Id,
            //        Name = member.Name,
            //        Phone = member.Phone,
            //        Photo = member.Photo,
            //        Email = member.Email,
            //        Gender = member.Gender.ToString()
            //    };
            //    listOfMembersViewModel.Add(memberViewModel);
            //}
            //return listOfMembersViewModel; 
            #endregion


            var membersViewModel = members.Select(M => new MemberViewModel
            {
                Id = M.Id,
                Name = M.Name,
                Phone = M.Phone,
                Photo = M.Photo,
                Email = M.Email,
                Gender = M.Gender.ToString()
            });
            return membersViewModel;
        }
    }
}
