using BussinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Linq;

namespace CandidateDAO
{
    public class HRAccountDAO
    {
        private static HRAccountDAO instance = null;
        private static CandidateManagementContext dbContext = null;
        public HRAccountDAO()
        {
            dbContext = new CandidateManagementContext();
        }

        public static HRAccountDAO Instance { 
            get
            {
                if (instance == null)
                {
                    instance = new HRAccountDAO();
                }
                return instance;
            }
        }

        public Hraccount GetHRAccountByEmail(String email)
        {
            try
            {
                //Try van co so du lieu de lay thong tin tai khoan theo email
                ///Hraccount hraccount = new Hraccount();
                return dbContext.Hraccounts.FirstOrDefault(account => account.Email == email);
                //return hraccount; //tra ve tai khoan da truy van
            }
            catch(Exception ex)
            { 
                throw new Exception();
            }
        }

        public List<Hraccount> GetHraccounts()
        {
            try
            {
                return dbContext.Hraccounts.ToList();
            } catch(Exception ex)
            {
                throw new Exception();
            }
        }

        public List<CandidateProfile> GetCandidateProfiles()
        {
            try
            {
                return dbContext.CandidateProfiles.ToList();
            }catch(Exception ex)
            {
                throw new Exception();
            }
        }
    }
}
