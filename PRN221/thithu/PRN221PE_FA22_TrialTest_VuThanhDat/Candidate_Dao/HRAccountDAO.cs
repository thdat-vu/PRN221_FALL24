using Candidate_BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate_Dao
{
    public class HRAccountDAO
    {
        private CandidateManagementContext HRContext;
        private static HRAccountDAO instance = null;
        public static HRAccountDAO Instance 
        { 
            get
            {
                if (instance == null)
                {
                    instance = new HRAccountDAO();
                }
                return instance;
            }
        }
        public HRAccountDAO() 
        {
            HRContext = new CandidateManagementContext();
        }
        
        public Hraccount GetHrAccount(string email)
        {
            return HRContext.Hraccounts.SingleOrDefault(m => m.Email.Equals(email));
        }

    }
}
