using Candidate_BusinessObjects.Models;
using Candidate_Dao;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate_Repositories
{
    public class HRAccountRepo : IHRAccountRepo
    {
        // public Hraccount GetHrAccount(string email) => HRAccountDAO.Instance.GetHrAccount(email);
        public Hraccount GetHrAccount(string email) => HRAccountDAO.Instance.GetHrAccount(email);
    }
}
