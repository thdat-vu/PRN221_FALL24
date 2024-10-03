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

        public bool DeleteJobPosting(string jobId) => JobPostingDAO.Instance.DeleteJobPosting(jobId);

        public JobPosting GetJobPosting(string jobId) => JobPostingDAO.Instance.GetJobPosting(jobId);
        

        public List<JobPosting> GetJobPostings() => JobPostingDAO.Instance.GetJobPostings();
        

        public bool UpdateJobPosting(JobPosting jobPosting) => JobPostingDAO.Instance.UpdateJobPosting(jobPosting);
        
    }
}
