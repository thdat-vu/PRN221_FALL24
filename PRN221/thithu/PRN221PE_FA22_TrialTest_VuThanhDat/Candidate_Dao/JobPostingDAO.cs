using Candidate_BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate_Daos
{
    public class JobPostingDAO
    {
        private CandidateManagementContext context;
        //Singleton design pattern
        private static JobPostingDAO instance;
        public JobPostingDAO()
        {
            context = new CandidateManagementContext();
        }
        public static JobPostingDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new JobPostingDAO();
                }
                return instance;
            }
        }
        public bool AddJobPosting(JobPosting jobPosting)
        {
            bool isSuccess = false;
            try
            {
                context.JobPostings.Add(jobPosting);
                context.SaveChanges();
                isSuccess = true;
            }
            catch (Exception ex)
            {
                //Write log
            }
            return isSuccess;
        }
        public JobPosting GetJobPosting(string jobId)
        {
            return context.JobPostings.SingleOrDefault(m => m.PostingId.Equals(jobId));
        }

        public bool UpdateJobPosting(JobPosting jobPosting)
        {
            bool isSuccess = false;
            try
            {
                JobPosting job = GetJobPosting(jobPosting.PostingId);
                if (job != null)
                {
                    //xử hàm update
                    context.JobPostings.Update(jobPosting);
                    context.SaveChanges();
                    isSuccess = true;
                }

            }
            catch (Exception ex)
            {

            }
            return isSuccess;
        }
        public bool DeleteJobPosting(string jobId)
        {
            bool isSuccess = false;
            try
            {
                JobPosting job = GetJobPosting(jobId);
                if (job != null)
                {
                    //xử hàm update
                    context.JobPostings.Remove(job);
                    isSuccess = true;
                }

            }
            catch (Exception ex)
            {

            }
            return isSuccess;
        }
    }
}
