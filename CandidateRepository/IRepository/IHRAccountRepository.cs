using BussinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandidateRepository.IRepository
{
    public interface IHRAccountRepository
    {
        public Hraccount GetHraccountByEmail(String  email);
        public List<Hraccount> GetHraccounts();

        public List<CandidateProfile> GetCandidateProfiles();
    }
}
