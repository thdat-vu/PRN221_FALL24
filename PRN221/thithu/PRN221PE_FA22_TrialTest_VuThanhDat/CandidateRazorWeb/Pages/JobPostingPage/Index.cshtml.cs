using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Candidate_BusinessObjects.Models;
using Candidate_Daos;
using Candidate_Services;

namespace CandidateRazorWeb.Pages.JobPostingPage
{
    public class IndexModel : PageModel
    {
        //WARNING: Sua nhu the nay
        private readonly IJobPostingService jobService;

        //WARNING: Sua nhu the nay
        public IndexModel(IJobPostingService jobPostService)
        {
            this.jobService = jobPostService;
        }

        public IList<JobPosting> JobPosting { get;set; } = default!;

        //WARNING: Sua nhu the nay
        public async Task OnGetAsync()
        {
            if (jobService.GetJobPostings() != null)
            {
                JobPosting = jobService.GetJobPostings();
            }
        }
    }
}
