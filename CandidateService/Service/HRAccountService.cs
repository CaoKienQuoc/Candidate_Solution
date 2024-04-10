using BussinessObject;
using CandidateRepository.IRepository;
using CandidateService.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandidateService.Service
{
    public class HRAccountService : IHRAccountService
    {
        private IHRAccountRepository iHrAccountRepository = null;
        public HRAccountService(IHRAccountRepository hrRepo)
        {
            this.iHrAccountRepository = hrRepo;   
        }

        public List<CandidateProfile> GetCandidateProfiles()
        {
            return iHrAccountRepository.GetCandidateProfiles();
        }

        public Hraccount GetHraccountByEmail(string email)
        {
            return iHrAccountRepository.GetHraccountByEmail(email);
        }


        public List<Hraccount> GetHraccounts()
        {
            return iHrAccountRepository.GetHraccounts();
        }
    }
}
