using Candidate_BusinessObjects.Models;
using Candidate_Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate_Services
{
    public class JobPosingService : IJobPostingService
    {
        private readonly IJobPostingRepo jPostRepo;

        public JobPosingService()
        {
            jPostRepo = new JobPostingRepo();
        }

        public bool AddJobPosting(JobPosting jobPosting)
        {
            return jPostRepo.AddJobPosting(jobPosting);
        }

        public bool DeleteJobPosting(string jobId)
        {
            return jPostRepo.DeleteJobPosting(jobId);
        }

        public JobPosting GetJobPosting(string jobId)
        {
            return jPostRepo.GetJobPosting(jobId);
        }

        public List<JobPosting> GetJobPostings()
        {
            return jPostRepo.GetJobPostings();
        }

        public bool UpdateJobPosting(JobPosting jobPosting)
        {
            return jPostRepo.UpdateJobPosting(jobPosting);
        }
    }
}
