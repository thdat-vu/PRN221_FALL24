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
    public class DetailsModel : PageModel
    {
        private readonly IJobPostingService _jobService;

        public DetailsModel(IJobPostingService jobService)
        {
            this._jobService = jobService;
        }

      public JobPosting JobPosting { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(string id)
        {
            // sua o day
            if (id == null || _jobService.GetJobPostings() == null)
            {
                return NotFound();
            }
            // sua o day
            var jobposting = _jobService.GetJobPosting(id);
            if (jobposting == null)
            {
                return NotFound();
            }
            else 
            {
                JobPosting = jobposting;
            }
            return Page();
        }
    }
}
