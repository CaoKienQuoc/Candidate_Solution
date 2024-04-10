using BussinessObject;
using CandidateDAO;
using CandidateRepository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandidateRepository.Repository
{
    public class HRAccountRepository : IHRAccountRepository
    {
        public List<CandidateProfile> GetCandidateProfiles()=>HRAccountDAO.Instance.GetCandidateProfiles();

        public Hraccount GetHraccountByEmail(string email)
            =>HRAccountDAO.Instance.GetHRAccountByEmail(email);

        public List<Hraccount> GetHraccounts() => HRAccountDAO.Instance.GetHraccounts();
    }
}
