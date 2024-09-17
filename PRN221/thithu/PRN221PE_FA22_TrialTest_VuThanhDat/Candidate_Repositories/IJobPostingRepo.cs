using Candidate_BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate_Repositories
{
    public interface IJobPostingRepo
    {
        public bool AddJobPosting(JobPosting jobPosting);
        public JobPosting GetJobPosting(string jobId);
        public bool UpdateJobPosting(JobPosting jobPosting);
        public bool DeleteJobPosting(string jobId);
    }
}
