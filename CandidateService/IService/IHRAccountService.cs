using BussinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandidateService.IService
{
    public interface IHRAccountService
    {
        public Hraccount GetHraccountByEmail(String email);

        public List<Hraccount> GetHraccounts();

        public List<CandidateProfile> GetCandidateProfiles();
    }
}
