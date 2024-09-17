using Candidate_BusinessObjects.Models;
using Candidate_Daos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate_Repositories
{
    public class JobPostingRepo : IJobPostingRepo
    {
        public bool AddJobPosting(JobPosting jobPosting) => JobPostingDAO.Instance.AddJobPosting(jobPosting);

        public bool DeleteJobPosting(string jobId)
        {
            throw new NotImplementedException();
        }

        public JobPosting GetJobPosting(string jobId)
        {
            throw new NotImplementedException();
        }

        public bool UpdateJobPosting(JobPosting jobPosting)
        {
            throw new NotImplementedException();
        }
    }
}
